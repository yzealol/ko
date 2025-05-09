public class Ko<T> where T:IComparable{

  int last;
  int len;
  T[] items;
T temp;
///compare comparar två koer
  public int compare(Ko<T> ko2){
for (int i = 0; i < len; i++)
{
  if(items[i].CompareTo(ko2.items[i])!=0){
    return -1;
  }

}
return 0;
  }
  ///add lägger till item i ko
 public void add(T e){
if(last<len-1){
  items [last+1]=e;
  last++;
}
}
 ///remove tar bort item från ko
  public void remove(int removeindex){
for (int i = removeindex; i < last; i++)
{
  items[i] = items[i+1];
}
last--;
  }
  ///swap byter plats på två items
  public void swap(int firstindex, int secondindex){
temp = items[firstindex];
items[firstindex] = items[secondindex];
items[secondindex] = temp;
  }
  /// isempty säger om kon är tom
  public bool isEmpty(){
Console.WriteLine(last<0);
return last<0;
  }
  ///printar ut items
  public void print(){
for (int i = 0; i <= last; i++)
{
  Console.WriteLine(items[i]);
}
  }
///ko lägger till ny längd
public Ko(int listlen){
len = listlen;
last = -1;
items = new T[len];
}



}
class Program{
public static void Main(){
Ko<bool> minko = new Ko<bool>(5);
Ko<bool> minko2 = new Ko<bool>(7);
minko.compare(minko2);
minko.print();
minko.add(true);
minko.print();
minko.remove(0);
minko.print();
minko.add(true);
minko.add(false);
minko.add(true);
minko.swap(0, 1);
minko.print();
minko.add(true);
minko.isEmpty();
}
}