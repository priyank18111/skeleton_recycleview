using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using AndroidX.RecyclerView.Widget;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Supercharge;
using System.Threading.Tasks;

namespace skeleton_recycleview
{
    class UserAdapter : RecyclerView.Adapter
    {
        private List<UserDataModel> mlist;
        private MainActivity mainActivity;

        public UserAdapter(List<UserDataModel> mlist, MainActivity mainActivity)
        {
            this.mlist = mlist;
            this.mainActivity = mainActivity;
        }

        public override int ItemCount => mlist.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            myViewHolder ViewHolder = holder as myViewHolder;
            ViewHolder.Binddata(mlist, position);
      
            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_layout, parent, false);
            return new myViewHolder(itemView);
        }
    }

    class myViewHolder : RecyclerView.ViewHolder
    {

        TextView nameTextView;
        TextView professionTextView;
        TextView cityTextView;
        ShimmerLayout shimmerLayout;
        RelativeLayout relative2;

        public myViewHolder(View itemView) : base(itemView)
        {
            nameTextView = itemView.FindViewById<TextView>(Resource.Id.user_name_textview);
            professionTextView = itemView.FindViewById<TextView>(Resource.Id.user_profession);
            cityTextView = itemView.FindViewById<TextView>(Resource.Id.user_address);
            shimmerLayout = itemView.FindViewById<ShimmerLayout>(Resource.Id.shimmer_view_container);
            relative2 = itemView.FindViewById<RelativeLayout>(Resource.Id.relativeLayout2);


            StartShimmer();

        }

        private async void StartShimmer()
        {
            shimmerLayout.Visibility = ViewStates.Visible;

            shimmerLayout.StartShimmerAnimation();

            await StopShimmer();
        }

        private async Task StopShimmer()
        {
            await Task.Delay(5000);
            relative2.Visibility = ViewStates.Visible;
            shimmerLayout.Visibility = ViewStates.Invisible;
        }

        internal void Binddata(List<UserDataModel> mlist, int position)
        {

            nameTextView.Text = mlist[position].getName();
            professionTextView.Text = mlist[position].getProfession();
            cityTextView.Text = mlist[position].getCity();
        }
    }

}