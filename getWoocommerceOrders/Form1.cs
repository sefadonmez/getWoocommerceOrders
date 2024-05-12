using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace getWoocommerceOrders
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
               }

        private async void btnGetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://website/wp-json/wc/v3/orders?consumer_key=URLKEY&consumer_secret=URLKEY";
                // WooCommerce REST API'sinden tüm siparişleri çek
                string responseBody = await client.GetStringAsync(url);

                // Gelen JSON verisini DataGridView'e ekleme
                var orders = JsonConvert.DeserializeObject<dynamic>(responseBody);
                dataGridViewOrders.DataSource = orders;

                MessageBox.Show("Siparişler başarıyla alındı ve DataGridView'e eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
           
                if (dataGridViewOrders.SelectedRows.Count > 0)
                {
                    dynamic selectedOrder = dataGridViewOrders.SelectedRows[0].DataBoundItem;

                    richTextBoxOrderDetails.Clear();
                    richTextBoxOrderDetails.AppendText($"ID: {selectedOrder.id}\n");
                    richTextBoxOrderDetails.AppendText($"Parent ID: {selectedOrder.parent_id}\n");
                    richTextBoxOrderDetails.AppendText($"Status: {selectedOrder.status}\n");
                    richTextBoxOrderDetails.AppendText($"Currency: {selectedOrder.currency}\n");
                    richTextBoxOrderDetails.AppendText($"Version: {selectedOrder.version}\n");
                    richTextBoxOrderDetails.AppendText($"Prices Include Tax: {selectedOrder.prices_include_tax}\n");
                    richTextBoxOrderDetails.AppendText($"Date Created: {selectedOrder.date_created}\n");
                    richTextBoxOrderDetails.AppendText($"Date Modified: {selectedOrder.date_modified}\n");
                    richTextBoxOrderDetails.AppendText($"Discount Total: {selectedOrder.discount_total}\n");
                    richTextBoxOrderDetails.AppendText($"Discount Tax: {selectedOrder.discount_tax}\n");
                    richTextBoxOrderDetails.AppendText($"Shipping Total: {selectedOrder.shipping_total}\n");
                    richTextBoxOrderDetails.AppendText($"Shipping Tax: {selectedOrder.shipping_tax}\n");
                    richTextBoxOrderDetails.AppendText($"Cart Tax: {selectedOrder.cart_tax}\n");
                    richTextBoxOrderDetails.AppendText($"Total: {selectedOrder.total}\n");
                    richTextBoxOrderDetails.AppendText($"Total Tax: {selectedOrder.total_tax}\n");
                    richTextBoxOrderDetails.AppendText($"Customer ID: {selectedOrder.customer_id}\n");
                    richTextBoxOrderDetails.AppendText($"order_key ID: {selectedOrder.order_key}\n");



                //

                richTextBoxOrderDetailsBilling.Clear();
                richTextBoxOrderDetailsBilling.AppendText($"First Name: {selectedOrder.billing.first_name}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Last Name: {selectedOrder.billing.last_name}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Company: {selectedOrder.billing.company}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Address 1: {selectedOrder.billing.address_1}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Address 2: {selectedOrder.billing.address_2}\n");
                richTextBoxOrderDetailsBilling.AppendText($"City: {selectedOrder.billing.city}\n");
                richTextBoxOrderDetailsBilling.AppendText($"State: {selectedOrder.billing.state}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Postcode: {selectedOrder.billing.postcode}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Country: {selectedOrder.billing.country}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Email: {selectedOrder.billing.email}\n");
                richTextBoxOrderDetailsBilling.AppendText($"Phone: {selectedOrder.billing.phone}\n");



                //

                richTextBoxOrderDetailsShipping.Clear();

                richTextBoxOrderDetailsShipping.AppendText($"First Name: {selectedOrder.shipping.first_name}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Last Name: {selectedOrder.shipping.last_name}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Company: {selectedOrder.shipping.company}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Address 1: {selectedOrder.shipping.address_1}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Address 2: {selectedOrder.shipping.address_2}\n");
                richTextBoxOrderDetailsShipping.AppendText($"City: {selectedOrder.shipping.city}\n");
                richTextBoxOrderDetailsShipping.AppendText($"State: {selectedOrder.shipping.state}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Postcode: {selectedOrder.shipping.postcode}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Country: {selectedOrder.shipping.country}\n");
                richTextBoxOrderDetailsShipping.AppendText($"Phone: {selectedOrder.shipping.phone}\n");

            }


        }
    }
}
