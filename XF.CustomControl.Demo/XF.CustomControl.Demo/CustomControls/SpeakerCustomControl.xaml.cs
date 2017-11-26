using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.CustomControl.Demo.CustomControls {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakerCustomControl : ContentView {

        public static readonly BindableProperty FullNameProperty = BindableProperty.Create(
                                                                           propertyName: "FullName",
                                                                           defaultValue: String.Empty,
                                                                           returnType: typeof(string),
                                                                           declaringType: typeof(SpeakerCustomControl),
                                                                           defaultBindingMode: BindingMode.TwoWay,
                                                                           propertyChanged: FullNamePropertyChanged);

        public string FullName {
            get { return base.GetValue(FullNameProperty).ToString(); }
            set { base.SetValue(FullNameProperty, value); }
        }

        private static void FullNamePropertyChanged(BindableObject bindable, object oldValue, object newValue) {

            var speakerControl = (SpeakerCustomControl)bindable;
            speakerControl.FullNameLabel.Text = (string)newValue;
        }


        public static readonly BindableProperty PositionProperty = BindableProperty.Create(
                                                                           propertyName: "Position",
                                                                           defaultValue: String.Empty,
                                                                           returnType: typeof(string),
                                                                           declaringType: typeof(SpeakerCustomControl),
                                                                           defaultBindingMode: BindingMode.TwoWay,
                                                                           propertyChanged: PositionPropertyChanged);

        public string Position {
            get { return base.GetValue(PositionProperty).ToString(); }
            set { base.SetValue(PositionProperty, value); }
        }

        private static void PositionPropertyChanged(BindableObject bindable, object oldValue, object newValue) {

            var speakerControl = (SpeakerCustomControl)bindable;
            speakerControl.PositionLabel.Text = (string)newValue;
        }

        public static readonly BindableProperty PhotoUrlProperty = BindableProperty.Create(
                                                                           propertyName: "PhotoUrl",
                                                                           defaultValue: String.Empty,
                                                                           returnType: typeof(string),
                                                                           declaringType: typeof(SpeakerCustomControl),
                                                                           defaultBindingMode: BindingMode.TwoWay,
                                                                           propertyChanged: PhotoUrlPropertyChanged);

        public string PhotoUrl {
            get { return base.GetValue(PositionProperty).ToString(); }
            set { base.SetValue(PositionProperty, value); }
        }

        private static void PhotoUrlPropertyChanged(BindableObject bindable, object oldValue, object newValue) {

            var speakerControl = (SpeakerCustomControl)bindable;
            try {
                speakerControl.PhotoUrlImage.Source = ImageSource.FromUri(new Uri((string)newValue));
            } catch {
                speakerControl.PhotoUrlImage.Source = ImageSource.FromUri(new Uri("http://via.placeholder.com/300"));
            }
        }


        public SpeakerCustomControl() {
            InitializeComponent();
        }
    }
}