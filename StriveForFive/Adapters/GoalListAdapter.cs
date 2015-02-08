using System;
using Android.Widget;
using Android.Content;
using Android.Views;
using Java.Util;



namespace StriveForFive
{
	public class GoalListAdapter : BaseAdapter
	{
		Context context;

		String[] goalListOptions = new string[]{
			"Drink 75 oz of water",
			"Walk 5 miles",
			"Floss my teeth",
			"Wake up by 7am",
			"No TV",
			"Read 30 pages",
			"Call mom",
			"Practice guitar",
			"Work on Tackle",
			"Do my homework",
			"Say hello to a stranger",
			"Sing in the shower",
			"Write a hand written letter",
			"Dance on the train",
			"Meditate",
			"Leave my desk for lunch",
			"Do a sketch",
			"Read current events",
			"Learn something new",
			"Exercise for 30 minutes",
			"Add a new song to a playlist",
			"Make veggies the main component to one meal",
			"Drink my morning shake",
			"Learn the lyrics to a new song",
			"Learn to cook a new dish",
			"Write in my blog",
			"Post a photo to my photostream",
			"Make my bed in the morning"
		};

		ArrayList goalListArray = new ArrayList ();

		public GoalListAdapter (Context context)
		{
			this.context = context;

			while (goalListArray.Size() < 5) {
				System.Random random = new System.Random ();
				int optionPosition = random.Next (goalListOptions.Length);
				String goalListOption = goalListOptions [optionPosition];
				if (!goalListArray.Contains (goalListOption)) {
					goalListArray.Add (goalListOption);
				}
			}
		}

		public override int Count {
			get {
				return goalListArray.Size();
			}
		}	

		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}

		public override long GetItemId (int position)
		{
			return 0;
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{

			String item = (String) goalListArray.Get (position);
			LayoutInflater inflater = (LayoutInflater) context.GetSystemService (Context.LayoutInflaterService);

			convertView = inflater.Inflate (Resource.Layout.GoalListItem, parent, false);
			CheckBox checkbox = convertView.FindViewById<CheckBox> (Resource.Id.title);
			checkbox.Text = item; 

			return convertView;
		}
	}
}

