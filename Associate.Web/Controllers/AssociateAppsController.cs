using Associate.Core;
using Associate.Infra;
using System;
using System.Net;
using System.Web.Mvc;


namespace Associate.Web.Controllers
{
    public class AssociateAppsController : Controller
    {

        private AssociateAppRepository db = new AssociateAppRepository();


        // GET: AssociateApps
        public ActionResult Index()
        {
            return View(db.GetAssociates());
        }

        // GET: AssociateApps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AssociateApp associateApp = db.FindById(Convert.ToInt32(id));

            if (associateApp == null)
            {
                return HttpNotFound();
            }
            return View(associateApp);
        }


        // GET: AssociateApps/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,District,Town,Image")] AssociateApp associateApp)
        {
            if (ModelState.IsValid)
            {

                db.Add(associateApp);

                return RedirectToAction("Index");
            }

            return View(associateApp);
        }


        // GET: AssociateApps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AssociateApp assosiateApp = db.FindById(Convert.ToInt32(id));

            if (assosiateApp == null)
            {
                return HttpNotFound();
            }
            return View(assosiateApp);
        }


        // POST: AssociateApps/Edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,District,Town,Image")] AssociateApp associateApp)
        {
            if (ModelState.IsValid)
            {
                db.Edit(associateApp);

                return RedirectToAction("Index");
            }
            return View(associateApp);
        }


        // GET: AssociateApps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            AssociateApp memberApp = db.FindById(Convert.ToInt32(id));

            if (memberApp == null)
            {
                return HttpNotFound();
            }
            return View(memberApp);
        }

        // POST: AssociateApps/Delete

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Remove(id);

            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }
    }
}