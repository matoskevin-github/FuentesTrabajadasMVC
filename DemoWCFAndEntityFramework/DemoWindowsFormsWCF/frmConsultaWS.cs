using DemoWindowsFormsWCF.ServiceProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormsWCF
{
    public partial class frmConsultaWS : Form
    {
        public frmConsultaWS()
        {
            InitializeComponent();
        }

        private void frmConsultaWS_Load(object sender, EventArgs e)
        {
            ServiceProductClient  client = new ServiceProductClient();
            this.dataGridViewProducts.DataSource = client.findAll().Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            }).ToList();
        }
    }
}
