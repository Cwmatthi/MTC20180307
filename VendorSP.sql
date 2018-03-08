

alter  proc sp_Vendorinfo
as

select v.Name [Business Name] , a.AddressLine1 [Address], a.City,v.PreferredVendorStatus [ Pref. Vendor]
from Purchasing.Vendor v
inner join	Person.BusinessEntityAddress bea
on	bea.BusinessEntityID = v.BusinessEntityID
inner join	person.Address a
on	a.AddressID = bea.AddressID
Order by [Business Name] asc