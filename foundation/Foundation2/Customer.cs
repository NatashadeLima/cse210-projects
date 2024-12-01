using System;
using System.Collections.Generic;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool ItsInUSA()
    {
        return _address.InUSA();
    }

    public string GetShippingInfo()
    {
        return $"{_name}\n{_address.DisplayAll()}";
    }
}