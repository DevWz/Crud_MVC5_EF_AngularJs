using Crud_MVC5_EF_AngularJs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_MVC5_EF_AngularJs.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public JsonResult GetFuncionario()
        {
            using (var db = new FuncionariosEntities())
            {
                List<Funcionario> listarFuncionarios = db.Funcionarios.ToList();
                return Json(listarFuncionarios);
            }
        }
    }
}