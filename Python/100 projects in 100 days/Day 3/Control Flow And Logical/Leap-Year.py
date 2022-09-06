
#>on every year that is evenly divisible by 4
#>**except** every year that is evenly divisible by 100
#>**unless** the year is also evenly divisible by 400`

def main():
     year = input("Enter a year: ")
     # validating
     
     if year.isnumeric() :
         # Converting year to an integer
         year = int(year)
         if year % 4 == 0:
             if year % 100 == 0:
                 if year % 400 == 0:
                     print("Leap Year")
                 else:
                     print("not a leap year")
             else:
                 print("not a leap year")
         else:
             print("not a leap year")
     else :
        print("This is not a valid year")

main()

