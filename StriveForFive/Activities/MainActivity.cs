using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace StriveForFive
{

[Activity(Label = "StriveForFive", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme") ]
	public class MainActivity : ActionBarActivity
{

		//Variables Defined

		private Button pickDate;
		private DateTime date;
		const int DATE_DIALOG_ID = 0;
		//button.Text = date.ToString ("d");

	
		protected override void OnCreate(Bundle bundle)

		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Show fragment on create
			GoalListFragment goalListFragment = new GoalListFragment ();

			FragmentTransaction fragmentTransaction = this.FragmentManager.BeginTransaction ();

			fragmentTransaction.Replace (Resource.Id.frame_container, goalListFragment).Commit();

			// Date Picker
			pickDate = FindViewById<Button> (Resource.Id.date_picker_btn);
		

			// add a click event handler to the button
			pickDate.Click += delegate { ShowDialog (DATE_DIALOG_ID); };
	

			// get the current date
			date = DateTime.Today;

			// display the current date (this method is below)
			UpdateDisplay ();

			// updates the date in the TextView

		}
		private void UpdateDisplay ()
		{
			pickDate.Text = date.ToString ("d");

		}

		protected override Dialog OnCreateDialog (int id)
		{
			return new DatePickerDialog (this, HandleDateSet, date.Year,
				date.Month - 1, date.Day);
		}

		void HandleDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
		{
			date = e.Date;
			pickDate.Text = date.ToString ("d");
			ReplaceFragment ();
		}

		private void ReplaceFragment(){
			GoalListFragment goalListFragment = new GoalListFragment ();
			FragmentTransaction fragmentTx = this.FragmentManager.BeginTransaction ();
			fragmentTx.Replace (Resource.Id.frame_container, goalListFragment).Commit ();

		}
	}

}
