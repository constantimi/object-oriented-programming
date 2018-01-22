all: cards

games.o: games.cc games.hh

opdeck.o: opdeck.cc

war.o: war.cc

composite.o: composite.cc composite.hh operation.hh

literal.o: literal.cc literal.hh operation.hh games.hh
	
cards.o: cards.cc

cards: games.o cards.o opdeck.o war.o
		g++ -o cards games.o cards.o opdeck.o war.o

clean:
	rm -fr *.o cards