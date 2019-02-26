using DemoASP.NetWCF.ServiceProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoASP.NetWCF
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ServiceProductClient client = new ServiceProductClient();
                this.GridViewProduct.DataSource = client.findAll().Select( p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();
                this.GridViewProduct.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceProductClient client = new ServiceProductClient();
                Product product = client.find(Convert.ToInt32(txtProductId.Text)); ;
                this.txtName.Text = product.Name.ToString();
                this.txtPrice.Text = product.Price.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}