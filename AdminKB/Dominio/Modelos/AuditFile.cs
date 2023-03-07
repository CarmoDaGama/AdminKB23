using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Dominio.Modelos
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01", IsNullable = false)]

    public partial class AuditFile
    {

        private AuditFileHeader headerField;

        private AuditFileMasterFiles masterFilesField;

        private AuditFileSourceDocuments sourceDocumentsField;

        /// <remarks/>
        public AuditFileHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public AuditFileMasterFiles MasterFiles
        {
            get
            {
                return this.masterFilesField;
            }
            set
            {
                this.masterFilesField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocuments SourceDocuments
        {
            get
            {
                return this.sourceDocumentsField;
            }
            set
            {
                this.sourceDocumentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileHeader
    {

        private string auditFileVersionField;

        private string companyIDField;

        private string taxRegistrationNumberField;

        private string taxAccountingBasisField;

        private string companyNameField;

        private string businessNameField;

        private AuditFileHeaderCompanyAddress companyAddressField;

        private string fiscalYearField;

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        private string currencyCodeField;

        private System.DateTime dateCreatedField;

        private string taxEntityField;

        private string productCompanyTaxIDField;

        private string softwareValidationNumberField;

        private string productIDField;

        private string productVersionField;

        private string telephoneField;

        private string faxField;

        private string emailField;

        private string websiteField;

        /// <remarks/>
        public string AuditFileVersion
        {
            get
            {
                return this.auditFileVersionField;
            }
            set
            {
                this.auditFileVersionField = value;
            }
        }

        /// <remarks/>
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <remarks/>
        public string TaxRegistrationNumber
        {
            get
            {
                return this.taxRegistrationNumberField;
            }
            set
            {
                this.taxRegistrationNumberField = value;
            }
        }

        /// <remarks/>
        public string TaxAccountingBasis
        {
            get
            {
                return this.taxAccountingBasisField;
            }
            set
            {
                this.taxAccountingBasisField = value;
            }
        }

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public string BusinessName
        {
            get
            {
                return this.businessNameField;
            }
            set
            {
                this.businessNameField = value;
            }
        }

        /// <remarks/>
        public AuditFileHeaderCompanyAddress CompanyAddress
        {
            get
            {
                return this.companyAddressField;
            }
            set
            {
                this.companyAddressField = value;
            }
        }

        /// <remarks/>
        public string FiscalYear
        {
            get
            {
                return this.fiscalYearField;
            }
            set
            {
                this.fiscalYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateCreated
        {
            get
            {
                return this.dateCreatedField;
            }
            set
            {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        public string TaxEntity
        {
            get
            {
                return this.taxEntityField;
            }
            set
            {
                this.taxEntityField = value;
            }
        }

        /// <remarks/>
        public string ProductCompanyTaxID
        {
            get
            {
                return this.productCompanyTaxIDField;
            }
            set
            {
                this.productCompanyTaxIDField = value;
            }
        }

        /// <remarks/>
        public string SoftwareValidationNumber
        {
            get
            {
                return this.softwareValidationNumberField;
            }
            set
            {
                this.softwareValidationNumberField = value;
            }
        }

        /// <remarks/>
        public string ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public string ProductVersion
        {
            get
            {
                return this.productVersionField;
            }
            set
            {
                this.productVersionField = value;
            }
        }

        /// <remarks/>
        public string Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string Website
        {
            get
            {
                return this.websiteField;
            }
            set
            {
                this.websiteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileHeaderCompanyAddress
    {

        private string addressDetailField;

        private string cityField;

        private string countryField;

        /// <remarks/>
        public string AddressDetail
        {
            get
            {
                return this.addressDetailField;
            }
            set
            {
                this.addressDetailField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileMasterFiles
    {

        private AuditFileMasterFilesCustomer[] customerField;

        private AuditFileMasterFilesProduct[] productField;

        private AuditFileMasterFilesTaxTableEntry[] taxTableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Customer")]
        public AuditFileMasterFilesCustomer[] Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public AuditFileMasterFilesProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxTableEntry", IsNullable = false)]
        public AuditFileMasterFilesTaxTableEntry[] TaxTable
        {
            get
            {
                return this.taxTableField;
            }
            set
            {
                this.taxTableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileMasterFilesCustomer
    {

        private string customerIDField;

        private string accountIDField;

        private string customerTaxIDField;

        private string companyNameField;

        private AuditFileMasterFilesCustomerBillingAddress billingAddressField;

        private string selfBillingIndicatorField;

        /// <remarks/>
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        public string AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }

        /// <remarks/>
        public string CustomerTaxID
        {
            get
            {
                return this.customerTaxIDField;
            }
            set
            {
                this.customerTaxIDField = value;
            }
        }

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public AuditFileMasterFilesCustomerBillingAddress BillingAddress
        {
            get
            {
                return this.billingAddressField;
            }
            set
            {
                this.billingAddressField = value;
            }
        }

        /// <remarks/>
        public string SelfBillingIndicator
        {
            get
            {
                return this.selfBillingIndicatorField;
            }
            set
            {
                this.selfBillingIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileMasterFilesCustomerBillingAddress
    {

        private string addressDetailField;

        private string cityField;

        private string postalCodeField;

        private string countryField;

        /// <remarks/>
        public string AddressDetail
        {
            get
            {
                return this.addressDetailField;
            }
            set
            {
                this.addressDetailField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileMasterFilesProduct
    {

        private string productTypeField;

        private string productCodeField;

        private string productGroupField;

        private string productDescriptionField;

        private string productNumberCodeField;

        /// <remarks/>
        public string ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }

        /// <remarks/>
        public string ProductCode
        {
            get
            {
                return this.productCodeField;
            }
            set
            {
                this.productCodeField = value;
            }
        }

        /// <remarks/>
        public string ProductGroup
        {
            get
            {
                return this.productGroupField;
            }
            set
            {
                this.productGroupField = value;
            }
        }

        /// <remarks/>
        public string ProductDescription
        {
            get
            {
                return this.productDescriptionField;
            }
            set
            {
                this.productDescriptionField = value;
            }
        }

        /// <remarks/>
        public string ProductNumberCode
        {
            get
            {
                return this.productNumberCodeField;
            }
            set
            {
                this.productNumberCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileMasterFilesTaxTableEntry
    {

        private string taxTypeField;

        private string taxCountryRegionField;

        private string taxCodeField;

        private string descriptionField;

        private string taxPercentageField;

        /// <remarks/>
        public string TaxType
        {
            get
            {
                return this.taxTypeField;
            }
            set
            {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public string TaxCountryRegion
        {
            get
            {
                return this.taxCountryRegionField;
            }
            set
            {
                this.taxCountryRegionField = value;
            }
        }

        /// <remarks/>
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string TaxPercentage
        {
            get
            {
                return this.taxPercentageField;
            }
            set
            {
                this.taxPercentageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocuments
    {

        private AuditFileSourceDocumentsSalesInvoices salesInvoicesField;

        private AuditFileSourceDocumentsMovementOfGoods movementOfGoodsField;

        private AuditFileSourceDocumentsWorkingDocuments workingDocumentsField;

        private AuditFileSourceDocumentsPayments paymentsField;

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoices SalesInvoices
        {
            get
            {
                return this.salesInvoicesField;
            }
            set
            {
                this.salesInvoicesField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsMovementOfGoods MovementOfGoods
        {
            get
            {
                return this.movementOfGoodsField;
            }
            set
            {
                this.movementOfGoodsField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsWorkingDocuments WorkingDocuments
        {
            get
            {
                return this.workingDocumentsField;
            }
            set
            {
                this.workingDocumentsField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsPayments Payments
        {
            get
            {
                return this.paymentsField;
            }
            set
            {
                this.paymentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoices
    {

        private string numberOfEntriesField;

        private string totalDebitField;

        private string totalCreditField;

        private AuditFileSourceDocumentsSalesInvoicesInvoice[] invoiceField;

        /// <remarks/>
        public string NumberOfEntries
        {
            get
            {
                return this.numberOfEntriesField;
            }
            set
            {
                this.numberOfEntriesField = value;
            }
        }

        /// <remarks/>
        public string TotalDebit
        {
            get
            {
                return this.totalDebitField;
            }
            set
            {
                this.totalDebitField = value;
            }
        }

        /// <remarks/>
        public string TotalCredit
        {
            get
            {
                return this.totalCreditField;
            }
            set
            {
                this.totalCreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Invoice")]
        public AuditFileSourceDocumentsSalesInvoicesInvoice[] Invoice
        {
            get
            {
                return this.invoiceField;
            }
            set
            {
                this.invoiceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoice
    {

        private string invoiceNoField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus documentStatusField;

        private string hashField;

        private string hashControlField;

        private string periodField;

        private string invoiceDateField;

        private string invoiceTypeField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes specialRegimesField;

        private string sourceIDField;

        private string systemEntryDateField;

        private string customerIDField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLine[] lineField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals documentTotalsField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax withholdingTaxField;

        /// <remarks/>
        public string InvoiceNo
        {
            get
            {
                return this.invoiceNoField;
            }
            set
            {
                this.invoiceNoField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        /// <remarks/>
        public string Hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        public string HashControl
        {
            get
            {
                return this.hashControlField;
            }
            set
            {
                this.hashControlField = value;
            }
        }

        /// <remarks/>
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public string InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        public string InvoiceType
        {
            get
            {
                return this.invoiceTypeField;
            }
            set
            {
                this.invoiceTypeField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes SpecialRegimes
        {
            get
            {
                return this.specialRegimesField;
            }
            set
            {
                this.specialRegimesField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public string SystemEntryDate
        {
            get
            {
                return this.systemEntryDateField;
            }
            set
            {
                this.systemEntryDateField = value;
            }
        }

        /// <remarks/>
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Line")]
        public AuditFileSourceDocumentsSalesInvoicesInvoiceLine[] Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals DocumentTotals
        {
            get
            {
                return this.documentTotalsField;
            }
            set
            {
                this.documentTotalsField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax WithholdingTax
        {
            get
            {
                return this.withholdingTaxField;
            }
            set
            {
                this.withholdingTaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentStatus
    {

        private string invoiceStatusField;

        private string invoiceStatusDateField;

        private string sourceIDField;

        private string sourceBillingField;

        /// <remarks/>
        public string InvoiceStatus
        {
            get
            {
                return this.invoiceStatusField;
            }
            set
            {
                this.invoiceStatusField = value;
            }
        }

        /// <remarks/>
        public string InvoiceStatusDate
        {
            get
            {
                return this.invoiceStatusDateField;
            }
            set
            {
                this.invoiceStatusDateField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public string SourceBilling
        {
            get
            {
                return this.sourceBillingField;
            }
            set
            {
                this.sourceBillingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceSpecialRegimes
    {

        private string selfBillingIndicatorField;

        private string cashVATSchemeIndicatorField;

        private string thirdPartiesBillingIndicatorField;

        /// <remarks/>
        public string SelfBillingIndicator
        {
            get
            {
                return this.selfBillingIndicatorField;
            }
            set
            {
                this.selfBillingIndicatorField = value;
            }
        }

        /// <remarks/>
        public string CashVATSchemeIndicator
        {
            get
            {
                return this.cashVATSchemeIndicatorField;
            }
            set
            {
                this.cashVATSchemeIndicatorField = value;
            }
        }

        /// <remarks/>
        public string ThirdPartiesBillingIndicator
        {
            get
            {
                return this.thirdPartiesBillingIndicatorField;
            }
            set
            {
                this.thirdPartiesBillingIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceLine
    {

        private string lineNumberField;

        private string productCodeField;

        private string productDescriptionField;

        private string quantityField;

        private string unitOfMeasureField;

        private string unitPriceField;

        private System.DateTime taxPointDateField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences referencesField;

        private string descriptionField;

        private string debitAmountField;

        private bool debitAmountFieldSpecified;

        private string creditAmountField;

        private bool creditAmountFieldSpecified;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax taxField;

        private string taxExemptionReasonField;

        private string taxExemptionCodeField;

        private string settlementAmountField;

        /// <remarks/>
        public string LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        public string ProductCode
        {
            get
            {
                return this.productCodeField;
            }
            set
            {
                this.productCodeField = value;
            }
        }

        /// <remarks/>
        public string ProductDescription
        {
            get
            {
                return this.productDescriptionField;
            }
            set
            {
                this.productDescriptionField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        public string UnitPrice
        {
            get
            {
                return this.unitPriceField;
            }
            set
            {
                this.unitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string DebitAmount
        {
            get
            {
                return this.debitAmountField;
            }
            set
            {
                this.debitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DebitAmountSpecified
        {
            get
            {
                return this.debitAmountFieldSpecified;
            }
            set
            {
                this.debitAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CreditAmount
        {
            get
            {
                return this.creditAmountField;
            }
            set
            {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditAmountSpecified
        {
            get
            {
                return this.creditAmountFieldSpecified;
            }
            set
            {
                this.creditAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public string TaxExemptionReason
        {
            get
            {
                return this.taxExemptionReasonField;
            }
            set
            {
                this.taxExemptionReasonField = value;
            }
        }

        /// <remarks/>
        public string TaxExemptionCode
        {
            get
            {
                return this.taxExemptionCodeField;
            }
            set
            {
                this.taxExemptionCodeField = value;
            }
        }

        /// <remarks/>
        public string SettlementAmount
        {
            get
            {
                return this.settlementAmountField;
            }
            set
            {
                this.settlementAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceLineReferences
    {

        private string referenceField;

        private string reasonField;

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public string Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceLineTax
    {

        private string taxTypeField;

        private string taxCountryRegionField;

        private string taxCodeField;

        private string taxPercentageField;

        /// <remarks/>
        public string TaxType
        {
            get
            {
                return this.taxTypeField;
            }
            set
            {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public string TaxCountryRegion
        {
            get
            {
                return this.taxCountryRegionField;
            }
            set
            {
                this.taxCountryRegionField = value;
            }
        }

        /// <remarks/>
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public string TaxPercentage
        {
            get
            {
                return this.taxPercentageField;
            }
            set
            {
                this.taxPercentageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotals
    {

        private string taxPayableField;

        private string netTotalField;

        private string grossTotalField;

        private AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment paymentField;

        /// <remarks/>
        public string TaxPayable
        {
            get
            {
                return this.taxPayableField;
            }
            set
            {
                this.taxPayableField = value;
            }
        }

        /// <remarks/>
        public string NetTotal
        {
            get
            {
                return this.netTotalField;
            }
            set
            {
                this.netTotalField = value;
            }
        }

        /// <remarks/>
        public string GrossTotal
        {
            get
            {
                return this.grossTotalField;
            }
            set
            {
                this.grossTotalField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceDocumentTotalsPayment
    {

        private string paymentMechanismField;

        private string paymentAmountField;

        private System.DateTime paymentDateField;

        /// <remarks/>
        public string PaymentMechanism
        {
            get
            {
                return this.paymentMechanismField;
            }
            set
            {
                this.paymentMechanismField = value;
            }
        }

        /// <remarks/>
        public string PaymentAmount
        {
            get
            {
                return this.paymentAmountField;
            }
            set
            {
                this.paymentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PaymentDate
        {
            get
            {
                return this.paymentDateField;
            }
            set
            {
                this.paymentDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsSalesInvoicesInvoiceWithholdingTax
    {

        private string withholdingTaxTypeField;

        private string withholdingTaxDescriptionField;

        private string withholdingTaxAmountField;

        /// <remarks/>
        public string WithholdingTaxType
        {
            get
            {
                return this.withholdingTaxTypeField;
            }
            set
            {
                this.withholdingTaxTypeField = value;
            }
        }

        /// <remarks/>
        public string WithholdingTaxDescription
        {
            get
            {
                return this.withholdingTaxDescriptionField;
            }
            set
            {
                this.withholdingTaxDescriptionField = value;
            }
        }

        /// <remarks/>
        public string WithholdingTaxAmount
        {
            get
            {
                return this.withholdingTaxAmountField;
            }
            set
            {
                this.withholdingTaxAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsMovementOfGoods
    {

        private string numberOfMovementLinesField;

        private string totalQuantityIssuedField;

        /// <remarks/>
        public string NumberOfMovementLines
        {
            get
            {
                return this.numberOfMovementLinesField;
            }
            set
            {
                this.numberOfMovementLinesField = value;
            }
        }

        /// <remarks/>
        public string TotalQuantityIssued
        {
            get
            {
                return this.totalQuantityIssuedField;
            }
            set
            {
                this.totalQuantityIssuedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocuments
    {

        private string numberOfEntriesField;

        private string totalDebitField;

        private string totalCreditField;

        private AuditFileSourceDocumentsWorkingDocumentsWorkDocument[] workDocumentField;

        /// <remarks/>
        public string NumberOfEntries
        {
            get
            {
                return this.numberOfEntriesField;
            }
            set
            {
                this.numberOfEntriesField = value;
            }
        }

        /// <remarks/>
        public string TotalDebit
        {
            get
            {
                return this.totalDebitField;
            }
            set
            {
                this.totalDebitField = value;
            }
        }

        /// <remarks/>
        public string TotalCredit
        {
            get
            {
                return this.totalCreditField;
            }
            set
            {
                this.totalCreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkDocument")]
        public AuditFileSourceDocumentsWorkingDocumentsWorkDocument[] WorkDocument
        {
            get
            {
                return this.workDocumentField;
            }
            set
            {
                this.workDocumentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocumentsWorkDocument
    {

        private string documentNumberField;

        private AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentStatus documentStatusField;

        private string hashField;

        private string hashControlField;

        private string periodField;

        private System.DateTime workDateField;

        private string workTypeField;

        private string sourceIDField;

        private System.DateTime systemEntryDateField;

        private object transactionIDField;

        private string customerIDField;

        private AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine[] lineField;

        private AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentTotals documentTotalsField;

        /// <remarks/>
        public string DocumentNumber
        {
            get
            {
                return this.documentNumberField;
            }
            set
            {
                this.documentNumberField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentStatus DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        /// <remarks/>
        public string Hash
        {
            get
            {
                return this.hashField;
            }
            set
            {
                this.hashField = value;
            }
        }

        /// <remarks/>
        public string HashControl
        {
            get
            {
                return this.hashControlField;
            }
            set
            {
                this.hashControlField = value;
            }
        }

        /// <remarks/>
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkDate
        {
            get
            {
                return this.workDateField;
            }
            set
            {
                this.workDateField = value;
            }
        }

        /// <remarks/>
        public string WorkType
        {
            get
            {
                return this.workTypeField;
            }
            set
            {
                this.workTypeField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime SystemEntryDate
        {
            get
            {
                return this.systemEntryDateField;
            }
            set
            {
                this.systemEntryDateField = value;
            }
        }

        /// <remarks/>
        public object TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Line")]
        public AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine[] Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentTotals DocumentTotals
        {
            get
            {
                return this.documentTotalsField;
            }
            set
            {
                this.documentTotalsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentStatus
    {

        private string workStatusField;

        private string workStatusDateField;

        private object reasonField;

        private string sourceIDField;

        private string sourceBillingField;

        /// <remarks/>
        public string WorkStatus
        {
            get
            {
                return this.workStatusField;
            }
            set
            {
                this.workStatusField = value;
            }
        }

        /// <remarks/>
        public string WorkStatusDate
        {
            get
            {
                return this.workStatusDateField;
            }
            set
            {
                this.workStatusDateField = value;
            }
        }

        /// <remarks/>
        public object Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public string SourceBilling
        {
            get
            {
                return this.sourceBillingField;
            }
            set
            {
                this.sourceBillingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLine
    {

        private string lineNumberField;

        private string productCodeField;

        private string productDescriptionField;

        private string quantityField;

        private string unitOfMeasureField;

        private string unitPriceField;

        private System.DateTime taxPointDateField;

        private string descriptionField;

        private string creditAmountField;

        private AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLineTax taxField;

        private string taxExemptionReasonField;

        private string taxExemptionCodeField;

        private string settlementAmountField;

        /// <remarks/>
        public string LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        public string ProductCode
        {
            get
            {
                return this.productCodeField;
            }
            set
            {
                this.productCodeField = value;
            }
        }

        /// <remarks/>
        public string ProductDescription
        {
            get
            {
                return this.productDescriptionField;
            }
            set
            {
                this.productDescriptionField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        public string UnitPrice
        {
            get
            {
                return this.unitPriceField;
            }
            set
            {
                this.unitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string CreditAmount
        {
            get
            {
                return this.creditAmountField;
            }
            set
            {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLineTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public string TaxExemptionReason
        {
            get
            {
                return this.taxExemptionReasonField;
            }
            set
            {
                this.taxExemptionReasonField = value;
            }
        }

        /// <remarks/>
        public string TaxExemptionCode
        {
            get
            {
                return this.taxExemptionCodeField;
            }
            set
            {
                this.taxExemptionCodeField = value;
            }
        }

        /// <remarks/>
        public string SettlementAmount
        {
            get
            {
                return this.settlementAmountField;
            }
            set
            {
                this.settlementAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocumentsWorkDocumentLineTax
    {

        private string taxTypeField;

        private string taxCountryRegionField;

        private string taxCodeField;

        private string taxPercentageField;

        /// <remarks/>
        public string TaxType
        {
            get
            {
                return this.taxTypeField;
            }
            set
            {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public string TaxCountryRegion
        {
            get
            {
                return this.taxCountryRegionField;
            }
            set
            {
                this.taxCountryRegionField = value;
            }
        }

        /// <remarks/>
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public string TaxPercentage
        {
            get
            {
                return this.taxPercentageField;
            }
            set
            {
                this.taxPercentageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsWorkingDocumentsWorkDocumentDocumentTotals
    {

        private string taxPayableField;

        private string netTotalField;

        private string grossTotalField;

        /// <remarks/>
        public string TaxPayable
        {
            get
            {
                return this.taxPayableField;
            }
            set
            {
                this.taxPayableField = value;
            }
        }

        /// <remarks/>
        public string NetTotal
        {
            get
            {
                return this.netTotalField;
            }
            set
            {
                this.netTotalField = value;
            }
        }

        /// <remarks/>
        public string GrossTotal
        {
            get
            {
                return this.grossTotalField;
            }
            set
            {
                this.grossTotalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPayments
    {

        private string numberOfEntriesField;

        private string totalDebitField;

        private string totalCreditField;

        private AuditFileSourceDocumentsPaymentsPayment[] paymentField;

        /// <remarks/>
        public string NumberOfEntries
        {
            get
            {
                return this.numberOfEntriesField;
            }
            set
            {
                this.numberOfEntriesField = value;
            }
        }

        /// <remarks/>
        public string TotalDebit
        {
            get
            {
                return this.totalDebitField;
            }
            set
            {
                this.totalDebitField = value;
            }
        }

        /// <remarks/>
        public string TotalCredit
        {
            get
            {
                return this.totalCreditField;
            }
            set
            {
                this.totalCreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Payment")]
        public AuditFileSourceDocumentsPaymentsPayment[] Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPayment
    {

        private string paymentRefNoField;

        private string periodField;

        private System.DateTime transactionDateField;

        private string paymentTypeField;

        private string descriptionField;

        private string systemIDField;

        private AuditFileSourceDocumentsPaymentsPaymentDocumentStatus documentStatusField;

        private AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[] paymentMethodField;

        private string sourceIDField;

        private string systemEntryDateField;

        private string customerIDField;

        private AuditFileSourceDocumentsPaymentsPaymentLine[] lineField;

        private AuditFileSourceDocumentsPaymentsPaymentDocumentTotals documentTotalsField;

        private AuditFileSourceDocumentsPaymentsPaymentWithholdingTax[] withholdingTaxField;

        /// <remarks/>
        public string PaymentRefNo
        {
            get
            {
                return this.paymentRefNoField;
            }
            set
            {
                this.paymentRefNoField = value;
            }
        }

        /// <remarks/>
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TransactionDate
        {
            get
            {
                return this.transactionDateField;
            }
            set
            {
                this.transactionDateField = value;
            }
        }

        /// <remarks/>
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string SystemID
        {
            get
            {
                return this.systemIDField;
            }
            set
            {
                this.systemIDField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsPaymentsPaymentDocumentStatus DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMethod")]
        public AuditFileSourceDocumentsPaymentsPaymentPaymentMethod[] PaymentMethod
        {
            get
            {
                return this.paymentMethodField;
            }
            set
            {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public string SystemEntryDate
        {
            get
            {
                return this.systemEntryDateField;
            }
            set
            {
                this.systemEntryDateField = value;
            }
        }

        /// <remarks/>
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Line")]
        public AuditFileSourceDocumentsPaymentsPaymentLine[] Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsPaymentsPaymentDocumentTotals DocumentTotals
        {
            get
            {
                return this.documentTotalsField;
            }
            set
            {
                this.documentTotalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WithholdingTax")]
        public AuditFileSourceDocumentsPaymentsPaymentWithholdingTax[] WithholdingTax
        {
            get
            {
                return this.withholdingTaxField;
            }
            set
            {
                this.withholdingTaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentDocumentStatus
    {

        private string paymentStatusField;

        private string paymentStatusDateField;

        private string sourceIDField;

        private string sourcePaymentField;

        /// <remarks/>
        public string PaymentStatus
        {
            get
            {
                return this.paymentStatusField;
            }
            set
            {
                this.paymentStatusField = value;
            }
        }

        /// <remarks/>
        public string PaymentStatusDate
        {
            get
            {
                return this.paymentStatusDateField;
            }
            set
            {
                this.paymentStatusDateField = value;
            }
        }

        /// <remarks/>
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        /// <remarks/>
        public string SourcePayment
        {
            get
            {
                return this.sourcePaymentField;
            }
            set
            {
                this.sourcePaymentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentPaymentMethod
    {

        private string paymentMechanismField;

        private string paymentAmountField;

        private System.DateTime paymentDateField;

        /// <remarks/>
        public string PaymentMechanism
        {
            get
            {
                return this.paymentMechanismField;
            }
            set
            {
                this.paymentMechanismField = value;
            }
        }

        /// <remarks/>
        public string PaymentAmount
        {
            get
            {
                return this.paymentAmountField;
            }
            set
            {
                this.paymentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PaymentDate
        {
            get
            {
                return this.paymentDateField;
            }
            set
            {
                this.paymentDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentLine
    {

        private string lineNumberField;

        private AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID sourceDocumentIDField;

        private string creditAmountField;

        /// <remarks/>
        public string LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        public AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID SourceDocumentID
        {
            get
            {
                return this.sourceDocumentIDField;
            }
            set
            {
                this.sourceDocumentIDField = value;
            }
        }

        /// <remarks/>
        public string CreditAmount
        {
            get
            {
                return this.creditAmountField;
            }
            set
            {
                this.creditAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentLineSourceDocumentID
    {

        private string originatingONField;

        private System.DateTime invoiceDateField;

        private string descriptionField;

        /// <remarks/>
        public string OriginatingON
        {
            get
            {
                return this.originatingONField;
            }
            set
            {
                this.originatingONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentDocumentTotals
    {

        private string taxPayableField;

        private string netTotalField;

        private string grossTotalField;

        /// <remarks/>
        public string TaxPayable
        {
            get
            {
                return this.taxPayableField;
            }
            set
            {
                this.taxPayableField = value;
            }
        }

        /// <remarks/>
        public string NetTotal
        {
            get
            {
                return this.netTotalField;
            }
            set
            {
                this.netTotalField = value;
            }
        }

        /// <remarks/>
        public string GrossTotal
        {
            get
            {
                return this.grossTotalField;
            }
            set
            {
                this.grossTotalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:OECD:StandardAuditFile-Tax:AO_1.01_01")]
    public partial class AuditFileSourceDocumentsPaymentsPaymentWithholdingTax
    {

        private string withholdingTaxTypeField;

        private string withholdingTaxDescriptionField;

        private string withholdingTaxAmountField;

        /// <remarks/>
        public string WithholdingTaxType
        {
            get
            {
                return this.withholdingTaxTypeField;
            }
            set
            {
                this.withholdingTaxTypeField = value;
            }
        }

        /// <remarks/>
        public string WithholdingTaxDescription
        {
            get
            {
                return this.withholdingTaxDescriptionField;
            }
            set
            {
                this.withholdingTaxDescriptionField = value;
            }
        }

        /// <remarks/>
        public string WithholdingTaxAmount
        {
            get
            {
                return this.withholdingTaxAmountField;
            }
            set
            {
                this.withholdingTaxAmountField = value;
            }
        }
    }
}
