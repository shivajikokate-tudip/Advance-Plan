using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1.Helpers
{
   public static class FormHelper
    {
        public static void OpenFormInContainer(Control container, Form form)
        {
            if (!(Application.OpenForms.OfType<Form>().Count() == 1))
            {
                form.TopLevel = false;
                container.Controls.Clear();
                container.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }
    }
}
