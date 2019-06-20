using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyInvestments.ModelViews
{
    public class UnitTrustViewModel
    {
        public ObservableCollection<UnitTrustModel> UnitTrustPackages { get; set; }

        public UnitTrustViewModel()
        {
            UnitTrustPackages = new ObservableCollection<UnitTrustModel>
            {
                new UnitTrustModel
                {
                    Title = "W&I BCI Active Income Fund Unit Trust",
                    AssetClass= "Asset Class: Multi-asset fund of funds portfolio with active asset allocation across fixed income strategies.",
                    Goal = "Goal: Deliver cash plus returns over the medium term and provide investors with enhanced income and capital stability.",
                    Risk = "Risk: Low"
                },
                new UnitTrustModel
                {
                    Title = "W&I BCI Balanced Fund of Funds Unit Trust",
                    AssetClass= "Asset Class: Multi asset class portfolio of unit trust funds,  including equities, bonds, property & cash",
                    Goal = "Goal: Long term growth of capital & income by investing in diversified range of assets & managers",
                    Risk = " Risk: Moderate"
                },
                new UnitTrustModel
                {
                    Title = "W&I BCI Balanced High Equity Unit Trust",
                    AssetClass= "Asset Class: Multi asset class portfolio of unit trust funds,  including equities, bonds, property & cash",
                    Goal = "Goal: Long term growth of capital & income by investing in diversified range of assets & managers",
                    Risk = "Risk: Moderate-High"
                },
                new UnitTrustModel
                {
                    Title = "W&I BCI Dynamic Equity Unit Trust",
                    AssetClass= "Asset Class: 100% equity only fund that can invest in small and mid cap SA companies",
                    Goal = "Goal: Provide investors with capital growth over the long term",
                    Risk = "Risk: High"
                },
                new UnitTrustModel
                {
                    Title = "W&I BCI Equity Unit Trust",
                    AssetClass= "Asset Class: Equity only fund",
                    Goal = "Goal: Provide investors with captical growth & income over the long term",
                    Risk = "Risk: High"
                }
            };
        }
    }
}
