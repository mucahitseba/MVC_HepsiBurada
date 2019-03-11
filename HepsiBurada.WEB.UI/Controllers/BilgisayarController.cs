using HepsiBurada.MODELS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Web.Helpers;
using HepsiBurada.BLL.Helpers;
using HepsiBurada.BLL.Repository;
using HepsiBurada.MODELS.Entities;
using System.Data.Entity.Validation;

namespace HepsiBurada.WEB.UI.Controllers
{
    public class BilgisayarController : Controller
    {
        // GET: Bilgisayar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<ActionResult> NotebookKayit(NotebookViewModel model)
        { 
            var adminId = HttpContext.User.Identity.GetUserId();
            try
            {
                #region NotebookKayitResim1
                if (model.PostedFileNotebookResim1 != null &&
                    model.PostedFileNotebookResim1.ContentLength > 0)
                {
                    var file = model.PostedFileNotebookResim1;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = StringHelper.UrlFormatConverter(fileName);
                    fileName += StringHelper.GetCode();
                    var klasoryolu = Server.MapPath("~/Notebook/");
                    var dosyayolu = Server.MapPath("~/Notebook/") + fileName + extName;

                    if (!Directory.Exists(klasoryolu))
                        Directory.CreateDirectory(klasoryolu);
                    file.SaveAs(dosyayolu);

                    WebImage img = new WebImage(dosyayolu);
                    img.Resize(250, 250, false);
                    img.AddTextWatermark("HepsiBuradaDb");
                    img.Save(dosyayolu);
                    var oldPath = model.NotebookResim1;
                    model.NotebookResim1 = "/Notebook/" + fileName + extName;

                    System.IO.File.Delete(Server.MapPath(oldPath));
                }


                #endregion

                #region NotebookKayitResim2
                if (model.PostedFileNotebookResim2 != null &&
                    model.PostedFileNotebookResim2.ContentLength > 0)
                {
                    var file = model.PostedFileNotebookResim2;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = StringHelper.UrlFormatConverter(fileName);
                    fileName += StringHelper.GetCode();
                    var klasoryolu = Server.MapPath("~/Notebook/");
                    var dosyayolu = Server.MapPath("~/Notebook/") + fileName + extName;

                    if (!Directory.Exists(klasoryolu))
                        Directory.CreateDirectory(klasoryolu);
                    file.SaveAs(dosyayolu);

                    WebImage img = new WebImage(dosyayolu);
                    img.Resize(250, 250, false);
                    img.AddTextWatermark("HepsiBuradaDb");
                    img.Save(dosyayolu);
                    var oldPath = model.NotebookResim2;
                    model.NotebookResim2 = "/Notebook/" + fileName + extName;

                    System.IO.File.Delete(Server.MapPath(oldPath));
                }
                #endregion

                #region NotebookKayitResim3
                if (model.PostedFileNotebookResim3 != null &&
                    model.PostedFileNotebookResim3.ContentLength > 0)
                {
                    var file = model.PostedFileNotebookResim3;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extName = Path.GetExtension(file.FileName);
                    fileName = StringHelper.UrlFormatConverter(fileName);
                    fileName += StringHelper.GetCode();
                    var klasoryolu = Server.MapPath("~/Notebook/");
                    var dosyayolu = Server.MapPath("~/Notebook/") + fileName + extName;

                    if (!Directory.Exists(klasoryolu))
                        Directory.CreateDirectory(klasoryolu);
                    file.SaveAs(dosyayolu);

                    WebImage img = new WebImage(dosyayolu);
                    img.Resize(250, 250, false);
                    img.AddTextWatermark("HepsiBuradaDb");
                    img.Save(dosyayolu);
                    var oldPath = model.NotebookResim3;
                    model.NotebookResim3 = "/Notebook/" + fileName + extName;

                    System.IO.File.Delete(Server.MapPath(oldPath));
                }
                #endregion

                var data = new Notebook
                {
                    AdminID = adminId,
                    NotebookMarka = model.NotebookMarka,
                    EklenmeTarihi = model.EklenmeTarihi,
                    NotebookEkranKartiHafiza = model.NotebookEkranKartiHafiza,
                    NotebookAgirlik = model.NotebookAgirlik,
                    NotebookEkranKartiMarka = model.NotebookEkranKartiMarka,
                    NotebookFiyat = model.NotebookFiyat,
                    NotebookGarantiSuresi = model.NotebookGarantiSuresi,
                    NotebookHarddisk = model.NotebookHarddisk,
                    NotebookIslemci = model.NotebookIslemci,
                    NotebookIsletimSistemi = model.NotebookIsletimSistemi,
                    NotebookRam = model.NotebookRam,
                    NotebookKlavye = model.NotebookKlavye,
                    NotebookRamTipi = model.NotebookRamTipi,
                    Elektronik = model.Elektronik,
                    NotebookID = model.NotebookID,
                    NotebookStok = model.NotebookStok,
                    NotebookResim1 = model.NotebookResim1,
                    NotebookResim2 = model.NotebookResim2,
                    NotebookResim3 = model.NotebookResim3
                };
                new NotebookRepo().Insert(data);
                TempData["Message"] = $"{model.NotebookID} no'lu kayıt başarıyla eklenmiştir";
                return RedirectToAction("Index", "Bilgisayar");
            }
            catch (DbEntityValidationException ex)
            {
                TempData["Model"] = new ErrorViewModel()
                {
                    Text = $"Bir hata oluştu: {EntityHelper.ValidationMessage(ex)}",
                    ActionName = "Index",
                    ControllerName = "Bilgisayar",
                    ErrorCode = 500
                };
                return RedirectToAction("Error", "Home");
            }
            catch (Exception ex)
            {
                TempData["Model"] = new ErrorViewModel()
                {
                    Text = $"Bir hata oluştu: {ex.Message}",
                    ActionName = "Index",
                    ControllerName = "Bilgisayar",
                    ErrorCode = 500
                };
                return RedirectToAction("Error", "Home");
            }

            

        }
    }
}