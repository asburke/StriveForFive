
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace StriveForFive
{
	public class GoalListFragment : Fragment
	{

		ListView goalList;
		GoalListAdapter goalListAdapter;



		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View contentView = inflater.Inflate(Resource.Layout.GoalList, container, false);

			goalList = contentView.FindViewById<ListView> (Resource.Id.goal_list);

			return contentView;
		}

		public override void OnResume ()
		{
			base.OnResume ();
			goalListAdapter = new GoalListAdapter (this.Activity);

			goalList.Adapter = goalListAdapter;
		}


	}
}

