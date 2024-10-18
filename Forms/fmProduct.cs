using Menagelec.Entities;
using Menagelec.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menagelec.Forms
{
    public partial class fmProduct : Form
    {
        public fmProduct(int productId)
        {
            InitializeComponent();
            Product product = ProductModel.FindById(productId);
            lb_product_designation.Text = product.getDesignation();
            lb_product_description.Text = product.getDescription();
            lb_product_price.Text = $"prix: {product.getPrice()}€";
            string imagePath = $"../../../assets/imagesProduit/{product.getImageFilePath()}";
            product_pb.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : Image.FromFile("../../../assets/imagesProduit/nophoto.jpg");
        }
    }
}
