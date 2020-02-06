using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcialAp2.Data;
using PrimerParcialAp2.Models;
using System;

namespace PrimerParcialAp2.Controllers
{
    public class ArticuloController : Controller
    {
        public static bool Guardar(Articulo articulos)
        {
            bool paso = false;
            Context contexto = new Context();
            try
            {
                if (contexto.articulo.Add(articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Context contexto = new Context();
            try
            {
                Articulo articulo = contexto.articulo.Find(id);
                if (articulo != null)
                {
                    contexto.Entry(articulo).State = EntityState.Deleted;
                }
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch (Exception) { throw; }
            return paso;
        }
        public static bool Modificar(Articulo articulos)
        {
            bool paso = false;
            Context contexto = new Context();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static Articulo Buscar(int id)
        {
            Articulo articulo = new Articulo();
            Context context = new Context();
            try
            {
                articulo = context.articulo.Find(id);
                context.Dispose();
            }
            catch (Exception) { throw; }
            return articulo;
        }

    }
}