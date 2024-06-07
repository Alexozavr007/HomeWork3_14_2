using System.Collections;

namespace HomeWork3_14_2;

public class MyList<T> : IEnumerable<T> {
    private List<T> innerList = new List<T>();

    public void Add(T a) {
        innerList.Add(a);
    } 

    public IEnumerator<T> GetEnumerator() {
        var y = new MyEnumerator<T>(this);
        return y;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public int CountElements {
        get { return innerList.Count; }
    }

    public T this[int index] {
        get {
            return innerList[index];
        }
        set {
            innerList[index] = value; 
        }
    } 
}

public class MyEnumerator<T> : IEnumerator<T> {

    private T _current;
    public T Current {
    
        get {
            return _current;
        }
        private set {
            _current = value;
        }
    }

    object IEnumerator.Current { get { return Current; } }

    private  MyList<T> _innerlist;
    private int _innerIndex;

    public MyEnumerator(MyList<T> list) {
        this._innerlist = list;
        Reset();
    }

    public void Dispose() {
    }

    public bool MoveNext() {
        if (_innerlist.CountElements > (_innerIndex + 1)) {
            _innerIndex++;
            Current = _innerlist[_innerIndex];
            return true;
        }else {
            return false;
        }
    }

    public void Reset() {
        _innerIndex = -1;
    }
}
