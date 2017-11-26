using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XF.CustomControl.Demo.Models;

namespace XF.CustomControl.Demo.ViewModels {

    public class SpeakersListPageViewModel {

        public ObservableCollection<Speaker> AllSpeakers { get; set; }

        public SpeakersListPageViewModel() {

            AllSpeakers = new ObservableCollection<Speaker>();

            // Some dummy data
            AllSpeakers.Add(new Speaker() { SpeakerId = 1, FullName = "Almir Vuk", Position = ".NET Developer", PhotoUrl = "https://avatars3.githubusercontent.com/u/15986629" });
            AllSpeakers.Add(new Speaker() { SpeakerId = 2, FullName = "Mario Rozic", Position = "MEAN Developer", PhotoUrl = "https://avatars2.githubusercontent.com/u/15254942" });
        }
    }
}
