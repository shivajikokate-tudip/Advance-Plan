using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1.Helpers
{
    public static class FormHelper
    {
        public static void OpenForm(Control container, Form form)
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

        public static void OpenForm(Form form)
        {
            if (!(Application.OpenForms.OfType<Form>().Count() == 1))
            {
                form.Show();
            }
        }

        public static void OpenForm(Form form, Point location)
        {
            if (!(Application.OpenForms.OfType<Form>().Count() == 1))
            {
                location.X +=  5;
                location.Y += 5;
                form.Location = location;
                form.Show();
            }
        }
    }
}
