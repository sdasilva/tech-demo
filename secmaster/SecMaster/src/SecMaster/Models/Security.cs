using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecMaster.Models
{
    public class Security
    {
        public ObjectId Id { get; set; }

        public int SecurityKey { get; set; }
        public int SecurityId { get; set; }
        public int RowCurrentFlag { get; set; }
        public int? SnapShotDateId { get; set; }
        public string SecurityCode { get; set; }
        public string SecurityDesc { get; set; }
        public string Sedol { get; set; }
        public string BbergCode { get; set; }
        public string ReutersCode { get; set; }
        public string BbergUniqueId { get; set; }
        public string BbergGlobalUniqueId { get; set; }
        public string Cusip { get; set; }
        public string Isin { get; set; }
        public string Ticker { get; set; }
        public string ReutersSuffix { get; set; }
        public int? SecurityPrincipalCurrencyId { get; set; }
        public string SecurityPrincipalCurrencyCode { get; set; }
        public string SecurityPrincipalCurrencyDesc { get; set; }
        public int? ReportingPrincipalCurrencyId { get; set; }
        public string ReportingPrincipalCurrencyCode { get; set; }
        public string ReportingPrincipalCurrencyDesc { get; set; }
        public int? LocalBasisCurrencyId { get; set; }
        public string LocalBasisCurrencyCode { get; set; }
        public string LocalBasisCurrencyDesc { get; set; }
        public int? RiskCurrencyId { get; set; }
        public string RiskCurrencyCode { get; set; }
        public string RiskCurrencyDesc { get; set; }
        public int? SecurityCountryId { get; set; }
        public string SecurityCountryCode { get; set; }
        public string SecurityCountryDesc { get; set; }
        public int? SecurityContinentId { get; set; }
        public string SecurityContinent { get; set; }
        public int? SecuritySubTypeId { get; set; }
        public string SecuritySubType { get; set; }
        public decimal? TradingFactor { get; set; }
        public decimal? PricingFactor { get; set; }
        public int? AnalystId { get; set; }
        public string AnalystCode { get; set; }
        public string AnalystDesc { get; set; }
        public int? AnalystTypeID { get; set; }
        public string AnalystType { get; set; }
        public int? ExchangeId { get; set; }
        public string ExchangeCode { get; set; }
        public string ExchangeDesc { get; set; }
        public int? AssetTypeId { get; set; }
        public string AssetTypeCode { get; set; }
        public string AssetTypeDesc { get; set; }
        public int? InvestmentTypeId { get; set; }
        public string InvestmentTypeCode { get; set; }
        public string InvestmentTypeDesc { get; set; }
        public int? SecurityGICSSubIndustryId { get; set; }
        public string SecurityGICSSubIndustry { get; set; }
        public int? SecurityGICSIndustryId { get; set; }
        public string SecurityGICSIndustry { get; set; }
        public int? SecurityGICSSectorId { get; set; }
        public string SecurityGICSSector { get; set; }
        public int? SecurityGICSIndustryGroupId { get; set; }
        public string SecurityGICSIndustryGroup { get; set; }
        public string ReportingGICSIndustryGroup { get; set; }
        public int? QuantityPrecision { get; set; }
        public string SecurityExtendedDesc { get; set; }
        public string SecurityType1 { get; set; }
        public string SecurityType2 { get; set; }
        public DateTime? ExpectedMaturityPayDate { get; set; }
        public int? OrigIssuerId { get; set; }
        public int? IssuerId { get; set; }
        public string IssuerCode { get; set; }
        public string IssuerDesc { get; set; }
        public int? IssuerTypeId { get; set; }
        public string IssuerType { get; set; }
        public int? IssuerCountryId { get; set; }
        public string IssuerCountryCode { get; set; }
        public string IssuerCountryDesc { get; set; }
        public int? IssuerContinentId { get; set; }
        public string IssuerContinent { get; set; }
        public int? IssuerIndustryId { get; set; }
        public string IssuerIndustry { get; set; }
        public int? IssuerGICSSectorId { get; set; }
        public string IssueGICSSector { get; set; }
        public int? IssuerGICSSubIndustryId { get; set; }
        public string IssuerGICSSubIndustry { get; set; }
        public int? IssuerGICSIndustryGroupId { get; set; }
        public string IssuerGICSIndustryGroup { get; set; }
        public int? RiskAssetTypeId { get; set; }
        public string RiskAssetType { get; set; }
        public int? RiskAssetGroupId { get; set; }
        public string RiskAssetGroupCode { get; set; }
        public string RiskAssetGroupDesc { get; set; }
        public string RelativeIndexCountryDesc { get; set; }
        public string RelativeIndex { get; set; }
        public string OriginalRiskCurrencyCode { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public decimal? CouponFrequency { get; set; }
        public string PutCall { get; set; }
        public bool? IsConvertible { get; set; }
        public bool? IsConvertibleBberg { get; set; }
        public bool? IsFlag144A { get; set; }
        public bool? IsRegS { get; set; }
        public bool? IsSecuredBberg { get; set; }
        public bool? IsDefaultedBberg { get; set; }
        public decimal? StrikePrice { get; set; }
        public decimal? CvConversionRatio { get; set; }
        public decimal? DayCountBasis { get; set; }
        public string FormPFCountryDesc { get; set; }
        public string FormPFInvestmentType { get; set; }
        public string FormPFLiquidityLevelCode { get; set; }
        public string FormPFLiquidityLevelDesc { get; set; }
        public string FormPFRegionDesc { get; set; }
        public string PriceLevelDesc { get; set; }
        public string FitchCreditRatingCode { get; set; }
        public string MoodysCreditRatingCode { get; set; }
        public string SPCreditRatingCode { get; set; }
        public string BestRating { get; set; }
        public int? UnderlyingSecurityId { get; set; }
        public string ContingentPayable { get; set; }
        public int? DeletedInd { get; set; }
        public string MarkitId { get; set; }
        public string LinId { get; set; }
        public string GenevaId { get; set; }
        public string EzeId { get; set; }
        public int? PrivateInd { get; set; }
        public string FitchCreditRatingCodeBbg { get; set; }
        public string MoodysCreditRatingCodeBbg { get; set; }
        public string SPCreditRatingCodeBbg { get; set; }
        public string BestCreditRatingCodeBbg { get; set; }
        public string CountryOfIncorporation { get; set; }
        public string WorstRating { get; set; }
        public string BestRatingRank { get; set; }
        public string WorstRatingRank { get; set; }

    }
}
