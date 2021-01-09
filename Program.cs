using System;

namespace icr
{
    public class program{
        static void Main(string[] args)
        { 
            Car c1 = new Car ("green", 2);
            Car c2 = new Car ("red", 4);
            Console.WriteLine ("This is a {0} door car.", c1.ToString());
            ParkingGarage g1 = new ParkingGarage(5);
            Console.WriteLine ("This garage has the capacity of {0} slots.", g1.getCapacity() );
            try {g1.parkCar (c1, 0);
            Console.WriteLine ("C1 is parked in the slot 0");}
            catch (Exception e) {Console.WriteLine("This is already occupied.");}
            try {g1.parkCar (c2, 0);
            Console.WriteLine ("C2 is parked in the slot 0");}
            catch (Exception e) {Console.WriteLine ("This slot has a car.");}
            
        }
    }

   public class Car {
       public string color {get; private set;}
       public int numDoor {get; private set;}
       public Car (string initialColor, int initialNumDoor) {
           this.color = initialColor;
           this.numDoor = initialNumDoor;
       }
    public string ToString () {
        string s = String.Format("{0} {1}", color, numDoor);
        return s;
    }
    }

    public class ParkingGarage {
private Car[] parkingSlots;
public int capacity {get; set;}
public ParkingGarage (int initialCapacity)   {
   this.capacity = initialCapacity;
   this.parkingSlots = new Car[initialCapacity];
   }    
   public int getCapacity (){
       return parkingSlots.Length;
   } 
   public void parkCar (Car theCar, int theSlot){
       if(this.parkingSlots[theSlot] != null){
           throw new Exception ("There is a car in this slot" + theSlot);
       }
       this.parkingSlots[theSlot]=theCar;
   }
    }

    
   
}
