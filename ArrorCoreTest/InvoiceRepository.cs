namespace ArrorCoreTest;

using System;
using System.Collections.Generic;
using System.Linq;

public class InvoiceRepository : IInvoiceRepository
{
    private IQueryable<Invoice> _invoices;

    public InvoiceRepository(IQueryable<Invoice> invoices)
    {
        // Console.WriteLine("Sample debug output");
        _invoices = invoices;
    }

    /// <summary>
    /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
    /// </summary>
    /// <param name="invoiceId"></param>
    /// <returns></returns>
    public decimal? GetTotal(int invoiceId)
    {
        var invoice = _invoices.Where(x => x.Id == invoiceId).FirstOrDefault();
        if (invoice == null) return Decimal.Zero;
        return invoice.InvoiceItems.Sum(x => x.Price * x.Count);
    }

    /// <summary>
    /// Should return a total value of all unpaid invoices.
    /// </summary>
    /// <returns></returns>
    public decimal GetTotalOfUnpaid()
    {
        var invoices = _invoices.Where(x => x.AcceptanceDate == null);
        decimal total = Decimal.Zero;
        foreach (var invoice in invoices)
        {
            total += invoice.InvoiceItems.Sum(x => x.Price * x.Count);
        }

        return total;
    }

    /// <summary>
    /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
    /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
    {
        IQueryable<Invoice> invoices;
        if (from != null && to != null)
        {
            invoices = _invoices.Where(x => x.CreationDate >= from).Where(x => x.CreationDate <= to);
        }
        else if (from == null && to != null)
        {
            invoices = _invoices.Where(x => x.CreationDate <= to);
        }
        else if (from != null && to == null)
        {
            invoices = _invoices.Where(x => x.CreationDate >= from);
        }
        else
        {
            invoices = _invoices;
        }

        Dictionary<string, long> result = new Dictionary<string, long>();
        foreach (var invoice in invoices)
        {
            foreach (var item in invoice.InvoiceItems)
            {
                if (result.ContainsKey(item.Name))
                {
                    result[item.Name] = result[item.Name] + item.Count;
                }
                else
                {
                    result.Add(item.Name, item.Count);
                }
            }
        }

        return result;
    }
}

// Please do not uncomment the classes.
public class Invoice
{
    // A unique numerical identifier of an invoice (mandatory)
    public int Id { get; set; }

    // A short description of an invoice (optional).
    public string Description { get; set; }

    // A number of an invoice e.g. 134/10/2018 (mandatory).
    public string Number { get; set; }

    // An issuer of an invoice e.g. Metz-Anderson, 600  Hickman Street,Illinois (mandatory).
    public string Seller { get; set; }

    // A buyer of a service or a product e.g. John Smith, 4285  Deercove Drive, Dallas (mandatory).
    public string Buyer { get; set; }

    // A date when an invoice was issued (mandatory).
    public DateTime CreationDate { get; set; }

    // A date when an invoice was paid (optional).
    public DateTime? AcceptanceDate { get; set; }

    // A collection of invoice items for a given invoice (can be empty but is never null).
    public IList<InvoiceItem> InvoiceItems { get; }

    public Invoice()
    {
        InvoiceItems = new List<InvoiceItem>();
    }
}

public class InvoiceItem
{
    // A name of an item e.g. eggs.
    public string Name { get; set; }

    // A number of bought items e.g. 10.
    public int Count { get; set; }

    // A price of an item e.g. 20.5.
    public decimal Price { get; set; }
}