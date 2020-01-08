import Class1 
import Class2 
import Class4


model = Class4.MinesweeperModel()
controller = Class2.MinesweeperController( model );
view = Class1.MinesweeperView( model, controller )
view.pack()
view.mainloop()