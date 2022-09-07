
import java.util.Scanner;


public class Main {
   
    public static void main(String[] args) {
        
        manageContacts();
    }
     public static void manageContacts(){
     
         Scanner scan = new Scanner(System.in);
         PhoneBook phonebook = new PhoneBook();
         
         phonebook.addContact(new Contact("Olivier Rodrigues","77-6754312", 22, "107 Arcadia Street Maineville, OH 45039","09/07/2000"));
         phonebook.addContact(new Contact("Patrick Rodrigues","77-6754314", 24, "107 Arcadia Street Maineville, OH 45039","09/07/1998"));
         
         System.out.println(phonebook);
         
    
         while (true){
             System.out.println("Would you like to \n\ta) add another contact \n\tb) remove a contact \n\tq) Exit the application\n\t ---- Type here ---: ");
             String response = scan.nextLine();
             if(response.equals("a")){
                 System.out.print("\tFullname : ");
                    String fullname = scan.nextLine();
                    
                 System.out.print("\tPhone number : ");
                    String phone = scan.nextLine();
                    
                 System.out.print("\tAge : ");
                    int age = scan.nextInt();
                    scan.nextLine();
                    
                 System.out.print("\tAddress : ");
                    String address = scan.nextLine();
                    
                 System.out.print("\tBirthday : ");
                    String birth = scan.nextLine();
                    
                try {
                    phonebook.addContact(new Contact(fullname,phone,age,address,birth));
                }catch(Exception ex){
                    ex.printStackTrace();
                }finally{
                    System.out.println("\n\n Updated Contact \n\n" + phonebook);
                } 
             }
             else if(response.equals("b")){
                 System.out.println("\n Who would you like to remove ?");
                 phonebook.removeContact(scan.nextLine());
                 System.out.println(phonebook);
             }else{
                 break;
             }
         }
     }
}
