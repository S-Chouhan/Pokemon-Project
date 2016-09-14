
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projectPokemon
{

    public partial class pokemonForm : Form
    {
        public pokemonForm()
        {
            InitializeComponent();
        }


        private void btnAmount_Click(object sender, EventArgs e)
        {
           
            float DiscountPercent = 0;
            float Amount = 0;

            pokemonOperation pokemonoperation = new pokemonOperation();

            if (txtPikachuNoOfQty.Text == "" || txtSquirtleNoOfQty.Text == "" || txtChamanderNoOfQty.Text == "")
            {
                MessageBox.Show("Qty Cannot be Empty");
                return;

            }

                  //When No purchase Made
            if (txtChamanderNoOfQty.Text == "0" && txtPikachuNoOfQty.Text == "0" && txtSquirtleNoOfQty.Text == "0")
            {
                lblAlert.Text = "No Purchase Made!!";
                return;
            }
            //Case1 when user only order Pikachu
            try
            {
                if (Convert.ToInt32(txtPikachuNoOfQty.Text) > 0 && txtChamanderNoOfQty.Text == "0" && txtChamanderNoOfQty.Text == "0")
                {

                    Amount = pokemonoperation.costForSelectedPokemonQuantity(Convert.ToInt32(txtPikachuNoOfQty.Text), 0, 0);
                    DiscountPercent = 0;
                }
                //Case2 when user only order Squirtle
                if (Convert.ToInt32(txtSquirtleNoOfQty.Text) > 0 && txtPikachuNoOfQty.Text == "0" && txtChamanderNoOfQty.Text == "0")
                {
                    Amount = pokemonoperation.costForSelectedPokemonQuantity(0, Convert.ToInt32(txtSquirtleNoOfQty.Text), 0);
                    DiscountPercent = 0;

                }
                //Case3 when user only order Charmander

                if (Convert.ToInt32(txtChamanderNoOfQty.Text) > 0 && txtPikachuNoOfQty.Text == "0" && txtSquirtleNoOfQty.Text == "0")
                {
                    Amount = pokemonoperation.costForSelectedPokemonQuantity(0, 0, Convert.ToInt32(txtChamanderNoOfQty.Text));
                    DiscountPercent = 0;

                }
                //Case4 when user order Pikachu and Squirtle

                if (Convert.ToInt32(txtPikachuNoOfQty.Text) > 0 && Convert.ToInt32(txtSquirtleNoOfQty.Text) > 0 && txtChamanderNoOfQty.Text == "0")
                {

                    DiscountPercent = 10;
                    if (Convert.ToInt32(txtPikachuNoOfQty.Text) == Convert.ToInt32(txtSquirtleNoOfQty.Text))
                    {
                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), Convert.ToInt32(txtSquirtleNoOfQty.Text));

                    }
                    else if (Convert.ToInt32(txtPikachuNoOfQty.Text) != Convert.ToInt32(txtSquirtleNoOfQty.Text))
                    {

                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), Convert.ToInt32(txtSquirtleNoOfQty.Text), 0);

                    }
                }

                //Case5 when user order  Squirtle and Charmander
                if (Convert.ToInt32(txtSquirtleNoOfQty.Text) > 0 && Convert.ToInt32(txtChamanderNoOfQty.Text) > 0 && txtPikachuNoOfQty.Text == "0")
                {
                    DiscountPercent = 10;
                    if (Convert.ToInt32(txtSquirtleNoOfQty.Text) == Convert.ToInt32(txtChamanderNoOfQty.Text))
                    {

                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(0, Convert.ToInt32(txtSquirtleNoOfQty.Text), Convert.ToInt32(txtChamanderNoOfQty.Text));


                    }
                    else if (Convert.ToInt32(txtSquirtleNoOfQty.Text) != Convert.ToInt32(txtChamanderNoOfQty.Text))
                    {

                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(0, Convert.ToInt32(txtSquirtleNoOfQty.Text), Convert.ToInt32(txtChamanderNoOfQty.Text));

                    }
                }

                //Case6 when user order Pikachu and Charmander
                if (Convert.ToInt32(txtChamanderNoOfQty.Text) > 0 && Convert.ToInt32(txtPikachuNoOfQty.Text) > 0 && txtSquirtleNoOfQty.Text == "0")
                {
                    DiscountPercent = 10;
                    if (Convert.ToInt32(txtChamanderNoOfQty.Text) == Convert.ToInt32(txtPikachuNoOfQty.Text))
                    {
                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), 0, Convert.ToInt32(txtChamanderNoOfQty.Text));

                    }
                    else if (Convert.ToInt32(txtChamanderNoOfQty.Text) != Convert.ToInt32(txtPikachuNoOfQty.Text))
                    {
                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), 0, Convert.ToInt32(txtChamanderNoOfQty.Text));

                    }
                }

                //Case7 when user order Pikachu , Squirtle and Charmander
                if (Convert.ToInt32(txtChamanderNoOfQty.Text) > 0 && Convert.ToInt32(txtSquirtleNoOfQty.Text) > 0 && Convert.ToInt32(txtPikachuNoOfQty.Text) > 0)
                {
                    DiscountPercent = 20;
                    if (txtChamanderNoOfQty.Text == txtSquirtleNoOfQty.Text && txtChamanderNoOfQty.Text == txtPikachuNoOfQty.Text)
                    {

                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), Convert.ToInt32(txtSquirtleNoOfQty.Text), Convert.ToInt32(txtChamanderNoOfQty.Text));

                    }
                    else
                    {
                        Amount = pokemonoperation.costForSelectedPokemonWithDiscount(Convert.ToInt32(txtPikachuNoOfQty.Text), Convert.ToInt32(txtSquirtleNoOfQty.Text), Convert.ToInt32(txtChamanderNoOfQty.Text));

                    }

                }
            }
            catch 
            {
                lblAlert.Text = "Please Enter Only Digits";
                lblAlert.ForeColor = System.Drawing.Color.Red;

            }

            txtDiscount.Text = DiscountPercent.ToString() + "%";
            txtAmountToPay.Text = Amount.ToString("C");
        }

        private void pokemonForm_Load(object sender, EventArgs e)
        {
            string[] aryPokemontype = { "Pikachu $6", "Squirtle $5", "Charmander $5" };

            // Dynamically creating lables on the form
            for (int lblcount = 0; lblcount <= aryPokemontype.Length - 1; lblcount++)
            {
                Label lblpokymonTxt = new Label();
                lblpokymonTxt.Text = aryPokemontype[lblcount];
                lblpokymonTxt.Size = new Size(64, 13);
                lblpokymonTxt.Location = new Point(77, 71 + lblcount * 41);
                lblpokymonTxt.AutoSize = true;

                this.Controls.Add(lblpokymonTxt);

            }
        }

    }
}
