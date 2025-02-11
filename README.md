<h1>Cardinal Insurance Policy Calculator</h1>

<h2>Description</h2>
This program provides a form for user input to determine the insurance costs based on the provided values.
<br />


<h2>Used to create:</h2>

- <b>Visual Studio 2022</b> 


<h2>Screenshots:</h2>
<img src="https://github.com/JrewSimpson/Cardinal-Insurance/blob/20bec94596a40f605ef66184b2f7775d632768e1/Cardinal%20Example1.JPG" height="80%" width="80%" alt="]"/>
<img src="https://github.com/JrewSimpson/Cardinal-Insurance/blob/20bec94596a40f605ef66184b2f7775d632768e1/Cardinal%20Example2.JPG" height="80%" width="80%" alt="]"/>

<h2>Code:</h2>

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Program2
    {
        public partial class Program2 : Form
        {
            public Program2()
            {
                InitializeComponent();
            }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            const int MONTH = 12; // Variable for covered months
            const double HEALTH_MED = 160.00; // Variable for basic rate for Medical insurance
            const double HEALTH_DEN = 20.00; // Variable for basic rate for Dental insurance
            const double HEALTH_VIS = 30.00; // Variable for basic rate of Vision insurance
            const double FULL_AUTO_BASE_RATE = 110.00; // Rate for Full auto insurance
            const double LIABILITY_AUTO_BASE_RATE = 50.00; // Rate for liability auto insurance
            const double YOUTH_INSURANCE_PREMIUM = 25.00; // Added premium for young drivers
            const double CAR_VALUE_DISCOUNT = .88; // Discount for low value cars
            const double CAR_VALUE_CUTOFF = 15000.00; // The cutoff for a car to be deemed low value
            const double SMOKING_PREMIUM = 70.00; // Added premium for smokers
            const double CAR_ACCIDENT_PREMIUM_FACTOR = 1.20; // Added premium for drivers with recent accidents

            int age, carValue; // Will hold inputs for age and car values

            double healthCoverageRate, carCoverageRate, totalCoverageRate; // Will hold total health, car, and combined rates

            bool hasAutoCoverage, hasMedicalCoverage; // Will hold true or false to whether the customer has car or health coverage
            // Input Validation, checks for valid age, car value, and list box choices
            if (int.TryParse(AgeInput.Text, out age) && (age >= 15) && (age <= 110))
            {
                if (int.TryParse(CarInput.Text, out carValue) && (carValue >= 0))
                {
                    if (HealthChoice.SelectedIndex >= 0)
                    {
                        if (CarChoice.SelectedIndex >= 0)
                        {
                            if (HealthChoice.Text == "Medical") // Next statements check for chosen health insurance
                            {
                                healthCoverageRate = HEALTH_MED;
                                hasMedicalCoverage = true;
                            }
                            else if (HealthChoice.Text == "Dental")
                            {
                                healthCoverageRate = HEALTH_DEN;
                                hasMedicalCoverage = false;
                            }
                            else if (HealthChoice.Text == "Vision")
                            {
                                healthCoverageRate = HEALTH_VIS;
                                hasMedicalCoverage = false;
                            }
                            else
                            {
                                healthCoverageRate = 0;
                                hasMedicalCoverage = false;
                            }

                            if ((hasMedicalCoverage == true) && (SmokeYes.Checked)) // Checks if user smokes and adds premium if "yes" is checked
                            {
                                healthCoverageRate = healthCoverageRate + SMOKING_PREMIUM;
                            }

                            // Car Coverage Calculations
                            if (CarChoice.Text == "Full")
                            {
                                carCoverageRate = FULL_AUTO_BASE_RATE;
                                hasAutoCoverage = true;
                            }
                            else if (CarChoice.Text == "Liability")
                            {
                                carCoverageRate = LIABILITY_AUTO_BASE_RATE;
                                hasAutoCoverage = false;
                            }
                            else
                            {
                                carCoverageRate = 0;
                                hasAutoCoverage = false;
                            }
                            // Special Calculations for young age, low valued car, and accidents
                            if (hasAutoCoverage == true)
                            {
                                if (carValue <= CAR_VALUE_CUTOFF)
                                {
                                    carCoverageRate = carCoverageRate * CAR_VALUE_DISCOUNT;
                                }
                                if (age <= 21)
                                {
                                    carCoverageRate = carCoverageRate + YOUTH_INSURANCE_PREMIUM;
                                }
                                if (AccidentYes.Checked)
                                {
                                    carCoverageRate = carCoverageRate * CAR_ACCIDENT_PREMIUM_FACTOR;
                                }
                            }
                            double YEARLY_CAR_PREMIUM = carCoverageRate * MONTH; // Holds the yearly car premium
                            double YEARLY_HEALTH_PREMIUM = healthCoverageRate * MONTH; // Holds the yearly health premium
                            totalCoverageRate = YEARLY_CAR_PREMIUM + YEARLY_HEALTH_PREMIUM; // Combines the yearly car and health insurance premiums
                            // Displays the values in the program
                            HealthCost.Text = "$" + YEARLY_HEALTH_PREMIUM.ToString("N2");
                            CarCost.Text = "$" + YEARLY_CAR_PREMIUM.ToString("N2");
                            TotalCost.Text = "$" + totalCoverageRate.ToString("N2");
                        }
                        else
                        {
                            MessageBox.Show("No Auto Policy Selected");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Health Policy Selected");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Car Value Inputted");
                }
            }
            else
            {
                MessageBox.Show("Invalid Age Inputted");
            }
        }
    }
    }
