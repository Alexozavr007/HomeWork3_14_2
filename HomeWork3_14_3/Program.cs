using HomeWork3_14_3;

var myDct = new MyDictionary<string, string>();
myDct.Add("das", "sad");
myDct.Add("asd", "asd");
myDct.Add("dsa", "dfs");

foreach (var d in myDct) {
   Console.WriteLine(d);
}

Console.WriteLine(myDct.DictionaryCount);