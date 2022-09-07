
import java.util.ArrayList;

/*
* Pradsley D'Haiti 
* Date : 9/7/2022
*/

public class Contact {
    
    private String fullname;
    private String phone;
    private int age;
    private String address;
    private String birthday;
  
    private static int totalContact = 0;
    
    // ======== Overloading Constructors
    public Contact(){
        fullname = "";
        phone = "";
        age = 0;
        address = "";
        birthday = "";
    }
    // Constructor with arguments
    public Contact(String f, String p, int a, String ad , String b){
        
        this.fullname = f;
        this.phone = p;
        this.age = a;
        this.address = ad;
        this.birthday = b;
        totalContact ++;
    }
    // ======== Copy Constructor
    public Contact(Contact source){    
        this.fullname = source.fullname;
        this.phone = source.phone;
        this.age = source.age;
        this.address = source.address;
        this.birthday = source.birthday;  
        totalContact ++;
    }
 //====================== Behaviors =============================
    // Getters and Setters
    
    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }
    
    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
        
    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }
    
    
    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }
    
    // This method display the number of contact in the phonebook
    public static void TotalContact(){
        System.out.println("Total of contact :" + totalContact );
    }
    
// To String method to display the object
    public String toString(){
        return " =========================\n"
             + " Fullname: " + fullname + "\n"
             + " Phone: " + phone + "\n" 
             + " Age: " + age + "\n"
             + " Address : " + address + "\n" 
             + " Birthday : " + birthday + "\n\n" 
             + "=================================";
  
    }

    public static void main(String[] args){
        Contact john = new Contact("Olivier Rodrigues","77-6754312", 22, "107 Arcadia Street Maineville, OH 45039","09/07/2000");
        System.out.println(john);
    }
     
}
