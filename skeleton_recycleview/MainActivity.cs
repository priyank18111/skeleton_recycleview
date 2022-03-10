using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Java.Lang;
using Supercharge;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace skeleton_recycleview
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<UserDataModel> mList;
        
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager _mylayoutmanger;
        UserAdapter mAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            
             
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);



           

            _mylayoutmanger = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(_mylayoutmanger);

            //mRecyclerView.SetItemAnimator(new DefaultItemAnimator());
            populateList();
            mAdapter = new UserAdapter(mList,this);
            mRecyclerView.SetAdapter(mAdapter);
           
            
              
       
        }
        private List<UserDataModel> populateList()
        {

            mList = new List<UserDataModel>();
            UserDataModel dataModel = new UserDataModel();
            dataModel.setName("Gaurav Kumar");
            dataModel.setProfession("Android Developer");
            dataModel.setCity("Noida");
            mList.Add(dataModel);

            UserDataModel dataModel1 = new UserDataModel();
            dataModel1.setName("Ashish Tiwari");
            dataModel1.setProfession("Unity Game Developer");
            dataModel1.setCity("Delhi");
            mList.Add(dataModel1);

            UserDataModel dataModel2 = new UserDataModel();
            dataModel2.setName("Pravesh Dubey");
            dataModel2.setProfession("Ios Developer");
            dataModel2.setCity("Pune");
            mList.Add(dataModel2);

            UserDataModel dataModel3 = new UserDataModel();
            dataModel3.setName("Praveen Singh togadia");
            dataModel3.setProfession("Web Developer");
            dataModel3.setCity("Gurgaon");
            mList.Add(dataModel3);

            UserDataModel dataModel4 = new UserDataModel();
            dataModel4.setName("Narendra singh");
            dataModel4.setProfession("Sql Developer");
            dataModel4.setCity("Banglore");
            mList.Add(dataModel4);

            return mList;


        }

    }

}
    