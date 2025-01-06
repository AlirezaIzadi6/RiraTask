# Coding Task
This windows console project is my try to show my coding style and ability to create a readable and maintainable structure.
The program consists of an abstract service to retrieve products data, and an implementation which uses a static list as the data store. I have used console output to show the service functionality.
## Description about LINQ queries
### Query 1: Get products by category
```
_productList.Where(p => p.Category == category)
```
It returns a list containing each product whose price is equal to the requested category. (Here category is an Enum type.)
### Query 2: Get the product with the highest price
Firstly I get the price value of the product(s) with highest price with the following query:
```
_productList.Max(p => p.Price)
```
And then use the retrieved value to find the first product with that price:
```
_productList.First(p => p.Price == maxPrice)
```
I'm not sure if this is the most efficient way of finding the product, but when querying to a database, I think it's better to include the first query in the main one to avoid overhead.
### Query 3: Get sum of all products prices
```
_productList.Sum(p => p.Price)
```
Simply calculates the total price for all products, It doesn't include any filters.
### Query 4: Get products for each category
```
_productList.GroupBy(p => p.Category)
    .Select(g => new
    {
        category = g.Key,
        products = g.ToList()
    })
```
At first, "GroupBy" method returns a collection of existing groups in the list. Then, in "Select" method I create an anonymous object to store each group's category value and list of products.
Then, I use the returned list of those anonymous objects, to populate the result dictionary.
### Query 5: Get average price of all products
```
_productList.Average(p => p.Price)
```
Like "Sum" method, this "Average" method calculates average for price values of all products.
