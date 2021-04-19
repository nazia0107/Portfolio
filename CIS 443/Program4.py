#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Prgram 4
Due Date: 11/23/2020
Grading ID: D9361

This program compares Shakespeare’s Macbeth to The Discovery of Guiana by Sir Walter Raleigh, 
Tamburlaine the Great, Part I by Christopher Marlowe, The Faithful Shepherdess by John Fletcher,and
The Advancement of Learning by Francis Bacon. These authors are who might have written Shakespeare’s works 

"""
#importing spacy module for similarity detection 
import spacy
from pathlib import Path  
nlp = spacy.load('en_core_web_md')  # using spacy's load function to load medium sized model

shakespeare = nlp(Path('Shakespeare.txt').read_text()) #Doc object for Shakespeare's Macbeth
marlowe = nlp(Path('Marlowe2.txt').read_text())         #Doc object for Marlowes's work
bacon = nlp(Path('FrancisBacon.txt').read_text())      #Doc object for Bacon's work
walter = nlp(Path('WalterRaleigh.txt').read_text()) #Doc object for Walter Raleigh's work
john = nlp(Path('JohnFletcher.txt').read_text()) #Doc object for John Fletcher's work

dif_marlowe = shakespeare.similarity(marlowe) #comparing Macbeth with Marlowe's work

dif_bacon = shakespeare.similarity(bacon)  #comparing Macbeth with Bacon's work
dif_raleigh = shakespeare.similarity(walter) #comparing Macbeth with Walter Raleigh's work
dif_fletcher= shakespeare.similarity(john)    ##comparing Macbeth with John Fletcher's work

#printing the similarity scores 
print(f'\nSimilarity between Shakespeare and Christopher Marlowe is:  {dif_marlowe}')
print(f'\nSimilarity between Shakespeare and Francis Bacon is: {dif_bacon}')
print(f'\nSimilarity between Shakespeare and Walter Raleigh is:  {dif_raleigh}')
print(f'\nSimilarity between Shakespeare and John Fetcher is: {dif_fletcher}')

#finding the most similar work to Macbeth
most_similar = max(dif_marlowe,dif_bacon, dif_raleigh, dif_fletcher )

print(f'\nMost similar work of John Fletcher with similarity value of: {most_similar}')

