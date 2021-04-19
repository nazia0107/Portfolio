# fig04_02.py
"""Simulating the dice game Craps."""
""" Grading ID: D9361"""
""" Program 3"""
""" Due: 11/2/2020"""



import random

def roll_dice():
    """Roll two dice and return their face values as a tuple."""
    die1 = random.randrange(1, 7)
    die2 = random.randrange(1, 7)
    return (die1, die2)  # pack die face values into a tuple

def display_dice(dice):
    """Display one roll of the two dice."""
    die1, die2 = dice  # unpack the tuple into variables die1 and die2

gamecount = 0      #initializing game count
win_c = 0          #initializing win count
loss_c = 0         #initializing loss count
roll_c = 0         #initializing roll count
wins = {}          #dictionary for wins
losses = {}        #dictionary for losses
while gamecount != 100000:
    roll_c = 0 
    die_values = roll_dice() # first roll
    roll_c += 1
    display_dice(die_values)

# determine game status and point, based on first roll
    sum_of_dice = sum(die_values)

    if sum_of_dice in (7, 11):  # win
        win_c += 1 
        gamecount += 1
        game_status = 'WON'
    elif sum_of_dice in (2, 3, 12):  # lose
        loss_c += 1 
        gamecount += 1
        game_status = 'LOST'
    else:  
        game_status = 'CONTINUE'
        my_point = sum_of_dice

# continue rolling until player wins or loses
    while game_status == 'CONTINUE':
        die_values = roll_dice()
        roll_c += 1  
        display_dice(die_values)
        sum_of_dice = sum(die_values)

        if sum_of_dice == my_point:  # win by making point
            game_status = 'WON'
            win_c += 1  
            gamecount += 1
        elif sum_of_dice == 7:  # lose by rolling 7
            game_status = 'LOST'
            loss_c += 1 
            gamecount += 1
    
    
    #Adding the wins and losses to dictionaries
    if game_status =='WON':
        if roll_c in wins:  
            wins[roll_c] += 1
        else:
            wins[roll_c] = 1
    if game_status=='LOST':
        if roll_c in losses:
            losses[roll_c] += 1
        else:
            losses[roll_c] = 1
    
            
print(f'Percentage of wins: {win_c*100/gamecount:>.2f}%') #displaying the percentage of wins
print(f'Percentage of losses: {loss_c*100/gamecount:>.2f}%') #displaying the percentage of losses
print('Percentage of wins/losses based on total number of rolls') 
print()
print('{:>25}{:>20} '.format('% Resolved','Cummulative %'))  #headers
print('{:<5}{:>20} {:>20}'.format('Rolls','on this roll','of games resolved')) #headers



win_keys = set(wins.keys())     #using set constructor to get keys from wins dictionary
loss_keys = set(losses.keys())  #using set constructor to get keys from losses dictionary
unique_val = win_keys.intersection(loss_keys)  


combined_dict = {}  #dictionary to hold combined key value pairs
for roll in unique_val:             
    combined_dict[roll] = wins[roll]+losses[roll]
    
    
total=0   
for roll in combined_dict:
    resolved = combined_dict[roll]/gamecount*100
    total += resolved
    if total <= 99.99:   #validation to avoid long tail
        print(f'{roll:>5}{resolved:>19.2f}%{total:>19.2f}%')





##########################################################################
# (C) Copyright 2019 by Deitel & Associates, Inc. and                    #
# Pearson Education, Inc. All Rights Reserved.                           #
#                                                                        #
# DISCLAIMER: The authors and publisher of this book have used their     #
# best efforts in preparing the book. These efforts include the          #
# development, research, and testing of the theories and programs        #
# to determine their effectiveness. The authors and publisher make       #
# no warranty of any kind, expressed or implied, with regard to these    #
# programs or to the documentation contained in these books. The authors #
# and publisher shall not be liable in any event for incidental or       #
# consequential damages in connection with, or arising out of, the       #
# furnishing, performance, or use of these programs.                     #
##########################################################################
