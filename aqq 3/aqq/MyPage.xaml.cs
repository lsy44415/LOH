using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace aqq
{


	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Skill { get; set; }
		[MaxLength(255)]
		public string Fname { get; set; }
		[MaxLength(255)]
		public string Lname { get; set; }
        public string Postcode { get; set; }
		public string Email { get; set; }
        public string Place { get; set; }
	}

    public class Place
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
    }



	public partial class MyPage : ContentPage
    {
		private SQLiteAsyncConnection _connection;
      //  private SQLiteAsyncConnection _connection2;
        private List<string> placelist;
        private ObservableCollection<Person> _people;
     //   private ObservableCollection<Place> _place;
		public MyPage()
        {
            InitializeComponent();
            SetPicker();
			_connection = DependencyService.Get<ISQLiteDb>().GetConnection();
          //  _connection2 = DependencyService.Get<ISQLiteDb>().GetConnection();

		}


		protected override async void OnAppearing()
		{
			await _connection.CreateTableAsync<Person>();

			var people = await _connection.Table<Person>().ToListAsync();
            _people = new ObservableCollection<Person>(people);
            listview1.ItemsSource = _people;

       //     await _connection2.CreateTableAsync<Place>();
        //    var place = await _connection2.Table<Place>().ToListAsync();
          //  _place = new ObservableCollection<Place>(place);
          // picker2.ItemsSource = _place;
			//picker2.SetBinding(Picker.ItemsSourceProperty, "Place");
			//picker2.ItemDisplayBinding = new Binding("Name");
            //for (int i = 0; i < placelist.Count; i++)
            //{
            //    var p = new Place
            //    {
            //        Name = placelist[i]
            //    };
            //    _place.Add(p);
            //}
            //await _connection2.InsertAllAsync(_place);

			base.OnAppearing();

		}

		//async void OnAdd(object sender, System.EventArgs e)
		//{
  //          var people = new Person
  //          {
  //          Skill = picker.SelectedItem.ToString(),
  //          Fname = fname.Text,
  //          Lname = lname.Text,
  //          Email = email.Text,
  //          Postcode = post.Text,
  //          Place=place.SelectedItem.ToString() };

  //          await _connection.InsertAsync(people);
  //          _people.Add(people);
           
		//}

		void OnUpdate(object sender, System.EventArgs e)
		{
		}

        async void OnDelete(object sender, System.EventArgs e)
        {
            if (_people.Count > 0)
            {
                var people = _people[0];
                await _connection.DeleteAsync(people);
                _people.Remove(people);
            }

        }

		 void click_display(object sender, System.EventArgs e)
		{
            listview1.IsVisible = true;
		}


		async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }


        async void Handle_Clicked2(object sender, System.EventArgs e)
        {
            try
            {
                if (fname.Text.isNum())
                {
                    label1.IsVisible = true;
                    label1.Text = "first name and last name cannot be blank or number ";
                }
                else
                {
                    label1.IsVisible = false;
                    if (lname.Text.isNum())
                    {
                        label2.IsVisible = true;
                        label2.Text = "last name cannot be blank or number ";
                    }
                    else
                    {
                        label2.IsVisible = false;
                        if (!picker.SelectedItem.ToString().Trim().Equals("") && switch1.IsToggled && !picker2.SelectedItem.ToString().Trim().Equals(""))
                        {
                            if (email.Text.isEmail())
                            {
                                label3.IsVisible = false;
                                if (post.Text.isPost())
                                {

                                    label4.IsVisible = false;


									var people = new Person
									{
										Skill = picker.SelectedItem.ToString(),
										Fname = fname.Text,
										Lname = lname.Text,
										Email = email.Text,
										Postcode = post.Text,
										
									};
                                   
									await _connection.InsertAsync(people);

									_people.Add(people);



                                    if (picker.SelectedItem.ToString().Equals("ICT"))
                                        await Navigation.PushAsync(new ResourcePage());
                                    else if (picker.SelectedItem.ToString().Equals("English"))
                                        await Navigation.PushAsync(new EnglishPage());
                                    else if (picker.SelectedItem.ToString().Equals("Health"))
                                        await Navigation.PushAsync(new HealthPage());
                                    else if (picker.SelectedItem.ToString().Equals("Food"))
                                        await Navigation.PushAsync(new FoodPage());
                                }
                                else
                                {
                                    label4.IsVisible = true;
                                    label4.Text = "you need to enter a valid postcode(e.g.3168)";
                                }

                            }
                            else
                            {
                                label3.IsVisible = true;
                                label3.Text = "you need to enter a valid email address(e.g.xx@gmail.com)";
                            }


                        }
                        else
                            await DisplayAlert("Alert", "you need to agree our requirements to continue", "ok");
                    }
                }

            }
            catch (NullReferenceException ex)
            {
                await DisplayAlert("Alert", "you need to choose one interest and the facilites and finish the form", "ok");
            }
        }


		void SetPicker()
		{
			placelist = new List<string> {
				"none",
				"AMES Australia",
				"Asylum Seeker Resource Centre",
				"Australian Karen Foundation",
				"Australian Red Cross",
				"Ballarat Community Health",
				"Ballarat Regional Multicultural Council",
				"Baptcare (Sanctuary)",
				"Bendigo Community Health Services",
				"Brigidine Asylum Seekers Project",
				"Brotherhood of St Laurence",
				"Brotherhood of St Laurence, Multicultural Communities Team",
				"Brunswick Connect",
				"Catholic Care",
				"Centre for Multicultural Youth",
				"cohealth",
				"ComputerBank",
				"Diversitat",
				"Familycare",
				"Fitted for Work ",
				"Fitzroy Learning Network",
				"Foundation House",
				"Jesuit Refugee Service",
				"Jesuit Social Services",
				"Life Without Barriers",
				"New Hope Foundation",
				"Noble Park English Language School ",
				"Refugee Legal",
				"RISE",
				"Salvation Army Asylum Seeker Support",
				"Save the Children",
				"Southern Migrant and Refugee Centre",
				"Spectrum Migrant Resource Centre",
				"Springvale Community Aid and Advice Bureau",
				"St Joseph's Flexible Learning Centre",
				"St Vincent de Paul Society Victoria ",
				"The Humanitarian Group",
				"Victorian Arabic Social Services",
				"Victorian Refugee Health Network",
				"Western Region Ethnic Communities Council",
				"Whittlesea Community Connections",
				"Women's Health in the South East",
				"Wyndham Community and Education Centre Inc"

			};
            picker2.ItemsSource= placelist;

		}


	}


}
