public class Ko<T> where T:IComparable{

  int last;
  int len;
  T[] items;
T temp;
  public int Compare(Ko<T> ko2){
for (int i = 0; i < len; i++)
{
  if(items[i].CompareTo(ko2.items[i])!=0){
    return -1;
  }

}
return 0;
  }
  
 public void Add(T e){
if(last<len-1){
  items [last+1]=e;
  last++;
}
}
 
  public void Remove(int removeindex){
for (int i = removeindex; i <= last; i++)
{
  items[removeindex] = items[removeindex+1];
}
last--;
  }
  public void Swap(int firstindex, int secondindex){
temp = items[firstindex];
items[firstindex] = items[secondindex];
items[secondindex] = temp;
  }
  public bool IsEmpty(){
Console.WriteLine(last<0);
return last<0;
  }
  public void print(){
Console.WriteLine(items);
  }

public Ko(int listlen){
len = listlen;
last = -1;
items = new T[len];
}



}
class Program{
public static void Main(){

}
}