using System;
using System.Collections.Generic;
using System.Text;

namespace Pagarme.DTO
{
    class BoletoRetornoDTO
    {
    }
}

public class Rootobject
{
    public string _object { get; set; }
    public string status { get; set; }
    public object refuse_reason { get; set; }
    public string status_reason { get; set; }
    public object acquirer_response_code { get; set; }
    public string acquirer_name { get; set; }
    public string acquirer_id { get; set; }
    public object authorization_code { get; set; }
    public object soft_descriptor { get; set; }
    public int tid { get; set; }
    public int nsu { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }
    public int amount { get; set; }
    public int authorized_amount { get; set; }
    public int paid_amount { get; set; }
    public int refunded_amount { get; set; }
    public int installments { get; set; }
    public int id { get; set; }
    public int cost { get; set; }
    public object card_holder_name { get; set; }
    public object card_last_digits { get; set; }
    public object card_first_digits { get; set; }
    public object card_brand { get; set; }
    public object card_pin_mode { get; set; }
    public bool card_magstripe_fallback { get; set; }
    public bool cvm_pin { get; set; }
    public object postback_url { get; set; }
    public string payment_method { get; set; }
    public string capture_method { get; set; }
    public object antifraud_score { get; set; }
    public string boleto_url { get; set; }
    public string boleto_barcode { get; set; }
    public DateTime boleto_expiration_date { get; set; }
    public string referer { get; set; }
    public string ip { get; set; }
    public object subscription_id { get; set; }
    public object phone { get; set; }
    public object address { get; set; }
    public Customer customer { get; set; }
    public object billing { get; set; }
    public object shipping { get; set; }
    public object[] items { get; set; }
    public object card { get; set; }
    public object split_rules { get; set; }
    public Metadata metadata { get; set; }
    public Antifraud_Metadata antifraud_metadata { get; set; }
    public object reference_key { get; set; }
    public object device { get; set; }
    public object local_transaction_id { get; set; }
    public object local_time { get; set; }
    public bool fraud_covered { get; set; }
    public object fraud_reimbursed { get; set; }
    public object order_id { get; set; }
    public string risk_level { get; set; }
    public object receipt_url { get; set; }
    public object payment { get; set; }
    public object addition { get; set; }
    public object discount { get; set; }
    public object private_label { get; set; }
}

public class Customer
{
    public string _object { get; set; }
    public int id { get; set; }
    public object external_id { get; set; }
    public string type { get; set; }
    public string country { get; set; }
    public object document_number { get; set; }
    public string document_type { get; set; }
    public string name { get; set; }
    public object email { get; set; }
    public object phone_numbers { get; set; }
    public object born_at { get; set; }
    public object birthday { get; set; }
    public object gender { get; set; }
    public DateTime date_created { get; set; }
    public Document[] documents { get; set; }
}

public class Document
{
    public string _object { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public string number { get; set; }
}

public class Metadata
{
}

public class Antifraud_Metadata
{
}
