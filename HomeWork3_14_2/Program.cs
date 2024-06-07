using HomeWork3_14_2;

var myList = new MyList<int>();
myList.Add(2011);
myList.Add(2020);
myList.Add(3133);
myList.Add(4898);

foreach (var item in myList) {
    Console.WriteLine(item);
}

Console.WriteLine($"Total length: {myList.CountElements}");