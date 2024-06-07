namespace HomeWork3_14_4; 
public static class Extensions {
    public static T[] GetArray<T>(this IEnumerable<T> list) {
        var arr = new T[list.Count()];
        int i = 0;
        foreach (var item in list) {
            arr[i++] = item;
        }
        return arr;
    }
}
