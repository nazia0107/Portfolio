import random


from collections import Counter

def roll_dice():
    """Roll two dice and return their face values as a tuple."""
    die1 = random.randrange(1, 7)
    die2 = random.randrange(1, 7)
    return (die1, die2)  # pack die face values into a tuple

def display_dice(dice):
    """Display one roll of the two dice."""
    die1, die2 = dice  # unpack the tuple into variables die1 and die2
    print(f'Player rolled {die1} + {die2} = {sum(dice)}')
def clear_values():
    """Clear rollcount  """


gamecount = 0
wincount = 0
losecount = 0
rollcount = 0
list_of_win = {}
list_of_loss = {}
#win_roll = {1:0, 2 : 0, 3 : 0, 4 : 0, 5 : 0, 6 : 0, 7 : 0, 8 : 0, 9 : 0, 10 : 0, 11 : 0, 12 : 0, 13 : 0, 14 : 0, 15 : 0, 16 : 0, 17 : 0, 18 : 0, 19 : 0}
#lose_roll = {1:0, 2 : 0, 3 : 0, 4 : 0, 5 : 0, 6 : 0, 7 : 0, 8 : 0, 9 : 0, 10 : 0, 11 : 0, 12 : 0, 13 : 0, 14 : 0, 15 : 0, 16 : 0, 17 : 0, 18 : 0, 19 : 0} 

while gamecount != 5:
    rollcount = 0
    die_values = roll_dice()
    rollcount += 1  # first roll
    display_dice(die_values)

# determine game status and point, based on first roll
    sum_of_dice = sum(die_values)

    if sum_of_dice in (7, 11):  # win
        wincount += 1
        gamecount += 1
        list_of_win = [{rollcount : key, "nbr": value} for key, value in Counter(list_of_win).values()]
        game_status = 'WON'
    elif sum_of_dice in (2, 3, 12):  # lose
        losecount += 1
        list_of_loss =[{rollcount : key, "nbr": value} for key, value in Counter(list_of_loss).values()]
        gamecount += 1
        game_status = 'LOST'
    else:  # remember point
        game_status = 'CONTINUE'
        my_point = sum_of_dice
        print('Point is', my_point)

# continue rolling until player wins or loses
    while game_status == 'CONTINUE':
        die_values = roll_dice()
        rollcount += 1
        display_dice(die_values)
        sum_of_dice = sum(die_values)

        if sum_of_dice == my_point:  # win by making point
            game_status = 'WON'
            wincount += 1
            list_of_win =[{rollcount : key, "nbr": value} for key, value in Counter(list_of_win).values()]
            gamecount += 1
        elif sum_of_dice == 7:  # lose by rolling 7
            game_status = 'LOST'
            losecount += 1
            list_of_loss =[{rollcount : key, "nbr": value} for key, value in Counter(list_of_loss).values()]
            gamecount += 1

# display "wins" or "loses" message

    if game_status == 'WON':
        print('Player wins')

    else:
        print('Player loses')
print(list_of_loss)
print(f'| {wincount} = wins |\n| {losecount} = losses |\n| {gamecount} = games played |')