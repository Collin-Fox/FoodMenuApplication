using FoodMenuApplication;

namespace foodTestOne
{
    public partial class Form1 : Form
    {
        API myApi = new API();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateButton.Text = "Update Menu";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            updateButton.Text = "Hello";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //This is where the button clicked handler is 
            //Add checks to make sure each text box is filled
            //Once all checks pass create a food object out of the text fields
            //Food objects will be created and returned to this application
            //the Food object will then be passed to a function that sends a POST request to API
            //Clear all the text fields if successful
            //Pass fake data first to not break server
            string storeId = idBox.Text;
            string name = nameBox.Text;
            string price = priceBox.Text;
            string img = imageBox.Text;
            food myFood = new food(storeId, name, price, img);
            label5.Text = myApi.getMethod(myFood);
            idBox.Text = "";
            nameBox.Text = "";
            priceBox.Text = "";
            imageBox.Text = "";



        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}