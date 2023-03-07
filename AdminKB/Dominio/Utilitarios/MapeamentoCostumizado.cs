using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Dominio.Utilitarios
{
    public class MapeamentoCostumizado<TModel, TView> where TView : class, new() where TModel : class, new()
    {
        public static List<TView> Map(List<TModel> listModels)
        {
            List<TView> views = new List<TView>();

            foreach (var model in listModels)
            {
                var view = new TView();
                var fields = model.GetType().GetProperties();
                foreach (var field in fields)
                {
                    if (view.GetType().GetProperties().Where(f => f.Name == field.Name && f.PropertyType.Name == field.PropertyType.Name).FirstOrDefault() != null)
                    {
                        view.GetType()
                            .GetProperty(field.Name)
                            .SetValue(
                                view,
                                field.GetValue(model)
                            );
                    }
                }
                views.Add(view);
            }

            return views;
        }
    }
}
