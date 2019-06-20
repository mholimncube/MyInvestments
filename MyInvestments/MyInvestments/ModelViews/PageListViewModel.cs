using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyInvestments.ModelViews
{
    public class PageListViewModel
    {
        public ObservableCollection<PageListModel> MyPageCollector { get; set; }

        public PageListViewModel()
        {
            MyPageCollector = new ObservableCollection<PageListModel>()
            {
                new PageListModel(){ Id=1, PageName ="Investments", PageDetails = "Investments info" },
                new PageListModel(){ Id=2, PageName ="Education", PageDetails = "Education info" },
                new PageListModel(){ Id=3, PageName ="Savings", PageDetails = "Savings info" },
                new PageListModel(){ Id=4, PageName ="News", PageDetails = " Transactionsinfo" },
                new PageListModel(){ Id=5, PageName ="Goals", PageDetails = "Goals info" },
                new PageListModel(){ Id=6, PageName ="Rewards", PageDetails = "Rewards info" },
                new PageListModel(){ Id=7, PageName ="About", PageDetails = "About info" }

            };
        }
    }
}
