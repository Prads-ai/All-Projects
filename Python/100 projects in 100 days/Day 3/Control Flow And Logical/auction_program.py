welcome = "Welcome to the secret auction program"
print(welcome)

bids = {}
others_bidders = 'y'
bidding_over = False
winner = ""
max_bid = 0

while others_bidders == 'y'.lower():
    name = input("What is your name : ")
    bid = int(input("What is your bid : "))

    # Add these variable to the dictionnary
    bids[name] = bid
    others_bidders = input("Are there any other bidders : ")
    # Add the dictionnary to the bids_log list

for topbidder, value in bids.items():
    if value > max_bid:
        max_bid = value
        winner = topbidder

bidding_over

print(f"The winner is {winner} with a bid of ${max_bid}")


