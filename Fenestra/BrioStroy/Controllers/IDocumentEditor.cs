using System;
namespace BrioStroy.Controllers
{
    interface IDocumentEditor
    {
        System.Web.Mvc.ActionResult Edit(Brio.Models.EditDocument model);
        System.Web.Mvc.ActionResult Edit(int id);
    }
}
