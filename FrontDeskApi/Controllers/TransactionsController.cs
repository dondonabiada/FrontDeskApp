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
	public class TransactionsController : Controller
	{
		private IUnitOfWorkFactory uowFactory;
		private IRepository<Transaction> repository;
		private IRepository<Customer> CustomerRepository;
		private IRepository<AreaBox> AreaBoxRepository;

		public TransactionsController()
		{
			FrontDeskAppDbModel context = new FrontDeskAppDbModel();
			this.uowFactory = new EntityFrameworkUnitOfWorkFactory(context);
			this.repository = new EntityFrameworkRepository<Transaction>(context);
			this.CustomerRepository = new EntityFrameworkRepository<Customer>(context);
			this.AreaBoxRepository = new EntityFrameworkRepository<AreaBox>(context);
		}

		//
		// GET: /Transactions

		public ViewResult Index(int? page, int? pageSize, string sortBy, bool? sortDesc , int? CustomerCustomerId, int? AreaBoxAreaBoxId)
		{
			// Defaults
			if (!page.HasValue)
				page = 1;
			if (!pageSize.HasValue)
				pageSize = 10;

			IQueryable<Transaction> query = (IQueryable<Transaction>)repository.All();
			query = query.OrderBy(x => x.TransactionId);
			// Filtering
			List<SelectListItem> selectList;
			if (CustomerCustomerId != null) {
				query = query.Where(x => x.CustomerId == CustomerCustomerId);
				ViewBag.CustomerCustomerId = CustomerCustomerId;
			}
			selectList = new List<SelectListItem>();
			selectList.Add(new SelectListItem() { Text = null, Value = null, Selected = CustomerCustomerId == null });
			selectList.AddRange(CustomerRepository.All().ToList().Select(x => new SelectListItem() { Text = x.LastName.ToString(), Value = x.CustomerId.ToString(), Selected = CustomerCustomerId != null && CustomerCustomerId == x.CustomerId }));
			ViewBag.Customers = selectList;
			ViewBag.SelectedCustomer = selectList.Where(x => x.Selected).Select(x => x.Text).FirstOrDefault();
			if (AreaBoxAreaBoxId != null) {
				query = query.Where(x => x.AreaBoxId == AreaBoxAreaBoxId);
				ViewBag.AreaBoxAreaBoxId = AreaBoxAreaBoxId;
			}
			selectList = new List<SelectListItem>();
			selectList.Add(new SelectListItem() { Text = null, Value = null, Selected = AreaBoxAreaBoxId == null });
			selectList.AddRange(AreaBoxRepository.All().ToList().Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.AreaBoxId.ToString(), Selected = AreaBoxAreaBoxId != null && AreaBoxAreaBoxId == x.AreaBoxId }));
			ViewBag.AreaBoxes = selectList;
			ViewBag.SelectedAreaBox = selectList.Where(x => x.Selected).Select(x => x.Text).FirstOrDefault();
			
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
				if (sortBy == "TransactionId")
					query = OrderBy(query, x => x.TransactionId, ascending);
				if (sortBy == "DateStored")
					query = OrderBy(query, x => x.DateStored, ascending);
				if (sortBy == "DateRetrieved")
					query = OrderBy(query, x => x.DateRetrieved, ascending);
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
		// GET: /Transactions/Create

		public ActionResult Create()
		{
			List<SelectListItem> selectList;
			selectList = new List<SelectListItem>();
			selectList.AddRange(CustomerRepository.All().ToList().Select(x => new SelectListItem() { Text = x.LastName.ToString(), Value = x.CustomerId.ToString(), Selected = null == x.CustomerId }));
			ViewBag.Customer = selectList;
			selectList = new List<SelectListItem>();
			selectList.AddRange(AreaBoxRepository.All().ToList().Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.AreaBoxId.ToString(), Selected = null == x.AreaBoxId }));
			ViewBag.AreaBox = selectList;
		    return View();
		} 
		
		//
		// POST: /Transactions/Create
		
		[HttpPost]
		public ActionResult Create(Transaction entity)
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
		// GET: /Transactions/Details
		
		public ViewResult Details(int TransactionId)
		{
			return View(repository.All().Single(x => x.TransactionId == TransactionId));
		}


		//
		// GET: /Transactions/Edit
				
		public ActionResult Edit(int TransactionId)
		{
			var entity = repository.All().Single(x => x.TransactionId == TransactionId);
			List<SelectListItem> selectList;
			selectList = new List<SelectListItem>();
			selectList.AddRange(CustomerRepository.All().ToList().Select(x => new SelectListItem() { Text = x.LastName.ToString(), Value = x.CustomerId.ToString(), Selected = entity.CustomerId == x.CustomerId }));
			ViewBag.Customer = selectList;
			selectList = new List<SelectListItem>();
			selectList.AddRange(AreaBoxRepository.All().ToList().Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.AreaBoxId.ToString(), Selected = entity.AreaBoxId == x.AreaBoxId }));
			ViewBag.AreaBox = selectList;
			return View(entity);
		}
				
		//
		// POST: /Transactions/Edit
				
		[HttpPost]
		public ActionResult Edit(Transaction entity)
		{
			if (ModelState.IsValid)
				using (IUnitOfWork uow = uowFactory.Create()) {
					Transaction original = repository.All().Single(x => x.TransactionId == entity.TransactionId);
					original.TransactionId = entity.TransactionId;
					original.CustomerId = entity.CustomerId;
					original.AreaBoxId = entity.AreaBoxId;
					original.DateStored = entity.DateStored;
					original.DateRetrieved = entity.DateRetrieved;
					original.Status = entity.Status;
					uow.Save();
					return RedirectToAction("Index");
				}
			else
				return View();
		}
		
		//
		// GET: /Transactions/Delete
		
		public ActionResult Delete(int TransactionId)
		{
			return View(repository.All().Single(x => x.TransactionId == TransactionId));
		}
		
		//
		// POST: /Transactions/Delete
		
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int TransactionId)
		{
			using (IUnitOfWork uow = uowFactory.Create()) {
				repository.Remove(repository.All().Single(x => x.TransactionId == TransactionId));
				uow.Save();
				return RedirectToAction("Index");
			}
		}

		private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, System.Linq.Expressions.Expression<Func<TSource, TKey>> keySelector, bool ascending) {

			return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
		}
	}
}

