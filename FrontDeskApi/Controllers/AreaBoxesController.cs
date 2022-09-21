using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FrontDeskApp.Entities;
using FrontDeskApp.Context;
using FrontDeskApp.Data;

namespace FrontDeskApi.Controllers
{
	public class AreaBoxesController : Controller
	{
		private IUnitOfWorkFactory uowFactory;
		private IRepository<AreaBox> repository;

		public AreaBoxesController()
		{
			FrontDeskAppDbModel context = new FrontDeskAppDbModel();
			this.uowFactory = new EntityFrameworkUnitOfWorkFactory(context);
			this.repository = new EntityFrameworkRepository<AreaBox>(context);
		}

		//
		// GET: /AreaBoxes

		public ViewResult Index(int? page, int? pageSize, string sortBy, bool? sortDesc )
		{
			// Defaults
			if (!page.HasValue)
				page = 1;
			if (!pageSize.HasValue)
				pageSize = 10;

			IQueryable<AreaBox> query = (IQueryable<AreaBox>)repository.All();
			query = query.OrderBy(x => x.AreaBoxId);
			
			// Paging
			int pageCount = (int)((query.Count() + pageSize - 1) / pageSize);
			if (page > 1)
				query = query.Skip((page.Value - 1) * pageSize.Value);
			query = query.Take(pageSize.Value);
			if (page > 1)
				ViewBag.Page = page.Value;
			if (pageSize != 10)
				ViewBag.PageSize = pageSize.Value;
			if (pageCount > 1) {
				int currentPage = page.Value;
				const int visiblePages = 5;
				const int pageDelta = 2;
				List<Tuple<string, bool, int>> paginationData = new List<Tuple<string, bool, int>>(); // text, enabled, page index
				paginationData.Add(new Tuple<string, bool, int>("Prev", currentPage > 1, currentPage - 1));
				if (pageCount <= visiblePages * 2) {
					for (int i = 1; i <= pageCount; i++)
						paginationData.Add(new Tuple<string, bool, int>(i.ToString(), true, i));
				}
				else {
					if (currentPage < visiblePages) {
						// 12345..10
						for (int i = 1; i <= visiblePages; i++)
							paginationData.Add(new Tuple<string, bool, int>(i.ToString(), true, i));
						paginationData.Add(new Tuple<string, bool, int>("...", false, -1));
						paginationData.Add(new Tuple<string, bool, int>(pageCount.ToString(), true, pageCount));
					}
					else if (currentPage > pageCount - (visiblePages - 1)) {
						// 1..678910
						paginationData.Add(new Tuple<string, bool, int>("1", true, 1));
						paginationData.Add(new Tuple<string, bool, int>("...", false, -1));
						for (int i = pageCount - (visiblePages - 1); i <= pageCount; i++)
							paginationData.Add(new Tuple<string, bool, int>(i.ToString(), true, i));
					}
					else {
						// 1..34567..10
						paginationData.Add(new Tuple<string, bool, int>("1", true, 1));
						paginationData.Add(new Tuple<string, bool, int>("...", false, -1));
						for (int i = currentPage - pageDelta, count = currentPage + pageDelta; i <= count; i++)
							paginationData.Add(new Tuple<string, bool, int>(i.ToString(), true, i));
						paginationData.Add(new Tuple<string, bool, int>("...", false, -1));
						paginationData.Add(new Tuple<string, bool, int>(pageCount.ToString(), true, pageCount));
					}
				}
				paginationData.Add(new Tuple<string, bool, int>("Next", currentPage < pageCount, currentPage + 1));
				ViewBag.PaginationData = paginationData;
			}

			// Sorting
			if (!string.IsNullOrEmpty(sortBy)) {
				bool ascending = !sortDesc.HasValue || !sortDesc.Value;
				if (sortBy == "Name")
					query = OrderBy(query, x => x.Name, ascending);
				if (sortBy == "AreaType")
					query = OrderBy(query, x => x.AreaType, ascending);
				if (sortBy == "Status")
					query = OrderBy(query, x => x.Status, ascending);
				ViewBag.SortBy = sortBy;
				if (sortDesc != null && sortDesc.Value)
					ViewBag.SortDesc = sortDesc.Value;
			}

			ViewBag.Entities = query.ToList();
			return View();
		}

		//
		// GET: /AreaBoxes/Create

		public ActionResult Create()
		{
		    return View();
		} 
		
		//
		// POST: /AreaBoxes/Create
		
		[HttpPost]
		public ActionResult Create(AreaBox entity)
		{
			if (ModelState.IsValid)
				using (IUnitOfWork uow = uowFactory.Create()) {
					repository.Add(entity);
					uow.Save();
					return RedirectToAction("Index");
				}
			else
				return View();
		}

		//
		// GET: /AreaBoxes/Details
		
		public ViewResult Details(int AreaBoxId)
		{
			return View(repository.All().Single(x => x.AreaBoxId == AreaBoxId));
		}


		//
		// GET: /AreaBoxes/Edit
				
		public ActionResult Edit(int AreaBoxId)
		{
			var entity = repository.All().Single(x => x.AreaBoxId == AreaBoxId);
			return View(entity);
		}
				
		//
		// POST: /AreaBoxes/Edit
				
		[HttpPost]
		public ActionResult Edit(AreaBox entity)
		{
			if (ModelState.IsValid)
				using (IUnitOfWork uow = uowFactory.Create()) {
					AreaBox original = repository.All().Single(x => x.AreaBoxId == entity.AreaBoxId);
					original.AreaBoxId = entity.AreaBoxId;
					original.Name = entity.Name;
					original.AreaType = entity.AreaType;
					original.Status = entity.Status;
					uow.Save();
					return RedirectToAction("Index");
				}
			else
				return View();
		}
		
		//
		// GET: /AreaBoxes/Delete
		
		public ActionResult Delete(int AreaBoxId)
		{
			return View(repository.All().Single(x => x.AreaBoxId == AreaBoxId));
		}
		
		//
		// POST: /AreaBoxes/Delete
		
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int AreaBoxId)
		{
			using (IUnitOfWork uow = uowFactory.Create()) {
				repository.Remove(repository.All().Single(x => x.AreaBoxId == AreaBoxId));
				uow.Save();
				return RedirectToAction("Index");
			}
		}

		private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, System.Linq.Expressions.Expression<Func<TSource, TKey>> keySelector, bool ascending) {

			return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
		}
	}
}

