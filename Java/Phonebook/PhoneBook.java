
import java.util.ArrayList;

/*
* Pradsley D'Haiti 
* Date : 9/7/2022
*/
public class PhoneBook {
    
    private ArrayList<Contact> contacts = new ArrayList<Contact>();
  
    //Constructor
    public PhoneBook(){
        this.contacts = new ArrayList<Contact>();
    }
    //============ Behaviors =========================
    public Contact getContact(int index){
        return new Contact(contacts.get(index));
    }
    // This method allow to edit a contact.
    public void setContact(Contact c, int index){
        contacts.set(index, new Contact(c));
    }
    // This method add a contact into the arraylist
    public void addContact(Contact c){
        contacts.add(new Contact(c));
    }
    public void removeContact(String name){
        if(contacts.isEmpty()){
            throw new IllegalStateException("Cannot delete an empty contact");
        }
        for(int i = 0; i < contacts.size(); i++){
            if(contacts.get(i).getFullname().equals(name)){
                contacts.remove(i);
            }
        }
    }
    
    // Display method
    public String toString(){
        String temp = "";
        for (int i = 0; i< contacts.size() ; i++){
           temp += contacts.get(i).toString();
        }
        return temp;
    }
}
