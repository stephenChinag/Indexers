public class Car {
 
 // private field 
 private string[] _brands = {"BMW", "Skoda","Camry", "Honda" };

// public indexer 1
public string this[int index]{
    set{
_brands[index] = value ;

    }get{
        return _brands[index];
    }
}


// public indexer 2
public string this[int index1 , string index2 ]{
    set{
_brands[index1] = value  ;

    }get{
        return _brands[index1]+ index2 ;
    }
}
}