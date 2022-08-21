using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web;
using System.Web.Mvc;
using U19106832_HW04.Models;

namespace U19106832_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        { 

            return View();

        }
        // GET: Documents
        public ActionResult Document()
        {
            // Get all the documents
            string[] Doc = Directory.GetFiles(Server.MapPath("~/App_Data/Document/"));
            // create a array of Doc model
            List<DocModel> documentList = new List<DocModel>();
            foreach (string doc in Doc)
            {
                // Create new document for every file in file array
                DocModel Doc1 = new DocModel();
                Doc1.DocumentName = Path.GetFileName(doc);
                // Add the document in the document models list
                documentList.Add(Doc1);
            }
            return View(documentList);
        }
        //Download the file
        public ActionResult Download(string DownloadDocument)
        {
            string Filepath = Server.MapPath("~/App_Data/Document/") + DownloadDocument;
            byte[] bytes = System.IO.File.ReadAllBytes(Filepath);
            return File(bytes, "application/octet-stream", DownloadDocument);
        }
        public ActionResult Delete(string DeleteDocument)
        {

            // the path of the file
            string fullPath = Request.MapPath("~/App_Data/Document/" + DeleteDocument);
            // delete the file from that path
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            return RedirectToAction("Index");
        }


        public ActionResult Donation()
        {
            string Name = new fname();
            string Surname = new sname();
            string TypeOfEvent = new tcondition();
            string Company = new Cname();
            int AmountPeople = new adonated(); 
            return View();
        }
        public ActionResult MedHistory()
        {
            string Name = new fname();
            string Surname = new sname();
            string TypeOfEvent = new tcondition();
            string Company = new Cname();
            int AmountPeople = new adonated();
            return View();
        }

    }
}