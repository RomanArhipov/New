from tkinter import *
from tkinter.messagebox import *
import random
MIN_ROW_COUNT = 5
MAX_ROW_COUNT = 30

MIN_COLUMN_COUNT = 5
MAX_COLUMN_COUNT = 30

MIN_MINE_COUNT = 1
MAX_MINE_COUNT = 800
class MinesweeperController:
    def __init__( self, model ):
        self.model = model

    def setView( self, view ):
        self.view = view

    def startNewGame( self ):
        gameSettings = self.view.getGameSettings()
        try:
            self.model.startGame( *map( int, gameSettings ) )
        except:
            self.model.startGame( self.model.rowCount, self.model.columnCount, self.model.mineCount )

        self.view.createBoard()

    def onLeftClick( self, row, column ):
        self.model.openCell( row, column )
        self.view.syncWithModel()
        if self.model.isWin():
            self.view.showWinMessage()
            self.startNewGame()
        elif self.model.isGameOver():
            self.view.showGameOverMessage()
            self.startNewGame()

    def onRightClick( self, row, column ):
        self.model.nextCellMark( row, column )
        self.view.blockCell( row, column, self.model.getCell( row, column ).state == 'flagged' )
        self.view.syncWithModel()


