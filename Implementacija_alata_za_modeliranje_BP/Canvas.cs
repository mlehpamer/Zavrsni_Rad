using Lucene.Net.Util;
using Microsoft.VisualC.StlClr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Implementacija_alata_za_modeliranje_BP
{
	class Canvas
	{
		private int eraPanelWidth;
		private int eraPanelHeight;
		private int eraStartingPositionX;
		private int eraStartingPositionY;
		private static int[,] matrix;
		private int newPointX;
		private int realEraPanelHeight;
		private int realEraPanelWidth;
		private int j = 1;
		private int biggestHeight;
		private int biggestWidth;

		//New points
		private int newStartX;
		private int newStartY;
		private int newEndX;
		private int newEndY;

		//Tables spaces
		private int tableSpace;

		//Docking points
		private int dockingStartPositionX;
		private int dockingStartPositionY;
		private int dockingEndPositionX;
		private int dockingEndPositionY;

		private string startTableDirection;
		private string endTableDirection;

		//BFS

		public Canvas(int eraPanelHeight, int eraPanelWidth, int eraStartingPositionX, int eraStartingPositionY, int realEraPanelHeight, int realEraPanelWidth)
		{
			this.eraPanelHeight = eraPanelHeight;
			this.eraPanelWidth = eraPanelWidth;
			this.eraStartingPositionX = eraStartingPositionX;
			this.eraStartingPositionY = eraStartingPositionY;
			matrix = new int[realEraPanelHeight,realEraPanelWidth];
			this.newPointX = eraStartingPositionX;
			this.realEraPanelHeight = realEraPanelHeight;
			this.realEraPanelWidth = realEraPanelWidth;
		}

		public void SetMatrixToEmpty()
		{
			for (int k =0 ; k < this.realEraPanelHeight; k++)
			{
				for (int l = 0; l < this.realEraPanelWidth; l++)
				{
					matrix[k, l] = 0;
				}
			}

			for(int k = 0; k < realEraPanelHeight; k++)
			{
				for(int l = 0; l < eraStartingPositionX; l++)
				{
					matrix[k, l] = 3;
				}
			}

			for(int k = 0; k < eraStartingPositionY; k++)
			{
				for(int l = 0; l < eraPanelWidth; l++)
				{
					matrix[k, l] = 3;
				}
			}
		}

		public void PrintMatrix()
		{
			for(int k = 0; k < realEraPanelHeight; k++)
			{
				for(int l = 0; l < realEraPanelWidth; l++)
				{
					System.Console.Write(matrix[k, l]);
				}
				System.Console.WriteLine();
			}
		}

		private void PaintMatrix(int startX,int startY, int height, int width)
		{
			for (int k = startY; k < startY + height; k++)
			{
				for (int l = startX; l < startX + width; l++)
				{
						matrix[k,l] = 1;
				}
			}
		}

		private void PaintMatrixMore(int startX, int startY, int height, int width)
		{
			for (int k = startY-4; k < startY + height+8; k++)
			{
				for (int l = startX-4; l < startX + width+8; l++)
				{
					if(matrix[k, l] == 0)
						matrix[k, l] = 4;
				}
			}
		}

		private int  FindNewCellDimensions(int biggestWidth, int biggestHeight, int rectangleSurface, int surfacePerTableAdded)
		{
			int newRectangleSurface = biggestWidth * biggestHeight;
			int i = 0;
			while (newRectangleSurface <= (rectangleSurface + surfacePerTableAdded)){
				biggestWidth++;
				biggestHeight++;
				newRectangleSurface = biggestWidth * biggestHeight;
				i++;
			}
			this.tableSpace = i / 2;
			return i;
		}

		public int[,] StartingTablePoints(int biggestWidht,int biggestHeight,int width,int height,int numberOfTables)
		{
			int numberOfRows = eraPanelHeight / biggestHeight;
			int numberOfCells = eraPanelWidth / biggestWidht;
			int numberOfSquares = numberOfRows * numberOfCells;
			int surfaceOfUnusedCells = (numberOfSquares - numberOfTables) * (biggestHeight * biggestWidht);
			int surfacePerTableAdded = surfaceOfUnusedCells / numberOfTables;
			int rectangleSurface = biggestWidht * biggestHeight;
			this.biggestHeight = biggestHeight;
			this.biggestWidth = biggestWidht;

			int i=FindNewCellDimensions(biggestWidht, biggestHeight, rectangleSurface,surfacePerTableAdded)/2;

			//Adding first row
			if (j == 1)
			{
				eraStartingPositionX += i;
				eraStartingPositionY += i;
				j++;
				PaintMatrix(eraStartingPositionX, eraStartingPositionY, height, width);
				PaintMatrixMore(eraStartingPositionX, eraStartingPositionY, height, width);

				return new int[eraStartingPositionX, eraStartingPositionY];
			}

			//Checking if it has to go in the new row
			if (eraStartingPositionX +biggestWidht*2+i*2>= realEraPanelWidth)
			{
				eraStartingPositionY += biggestHeight + i;
				eraStartingPositionX = newPointX+i;
				PaintMatrix(eraStartingPositionX, eraStartingPositionY, height, width);
				PaintMatrixMore(eraStartingPositionX, eraStartingPositionY, height, width);
				return new int[eraStartingPositionX, eraStartingPositionY];
			}			
			eraStartingPositionX += biggestWidht + i*2;
			PaintMatrix(eraStartingPositionX, eraStartingPositionY, height, width);
			PaintMatrixMore(eraStartingPositionX, eraStartingPositionY, height, width);

			return new int[eraStartingPositionX, eraStartingPositionY];
		}


		//Drawing paths
		public Point [] MyDrawingPathStartTable(int startX,int startY, int startWidth, int startHeight)
		{
			Point[] points ={
				new Point(newStartX,newStartY),
				new Point(newEndX,newEndY)
			};

			List<Point> listOfPoint = new List<Point>();

			Position startPosition = new Position(newStartX, newStartY);
			
			Position currentPosition = startPosition;

				//0 right
				//1 left
				//2 down
				//3 up
				List<Position> listOfDirections = new List<Position>
				{
					new Position(currentPosition.x + 1, currentPosition.y),
					new Position(currentPosition.x - 1, currentPosition.y),
					new Position(currentPosition.x , currentPosition.y+1),
					new Position(currentPosition.x , currentPosition.y-1)
				};

				//Drawing starting table connection
				foreach (var direction in listOfDirections)
				{

					if (matrix[direction.y,direction.x] != 1)
					{
						int z = 0;
					listOfPoint.Add(new Point(currentPosition.x, currentPosition.y));
						currentPosition = direction;
					int index = listOfDirections.IndexOf(direction);

					int m =NumberOfConnectionOnSide(startX, startY, startWidth, startHeight, index);
						while (z < 15)//+m*3)
						{
						matrix[currentPosition.y, currentPosition.x] = 2;
						
							if (index == 0)
							{

								currentPosition.x += 1;
								startTableDirection = "Right";
							}
							if (index == 1)
							{
								currentPosition.x -= 1;
								startTableDirection = "Left";
							}
							if (index == 2)
							{
								currentPosition.y += 1;
							startTableDirection = "Down";
							}
							if (index == 3)
							{
								currentPosition.y -= 1;
							startTableDirection = "Up";
							}
							listOfPoint.Add(new Point(currentPosition.x, currentPosition.y));
							z++;
						}
					this.dockingStartPositionX = currentPosition.x;
					this.dockingStartPositionY = currentPosition.y;
						//break;
						
					}
				}

			Point[] points1 = listOfPoint.ToArray();

			
			return points1;
		}

		public Point [] MyDrawingPathEndTable(int endX,int endY,int endWidth,int endHeight)
		{
			List<Point> listOfPoint = new List<Point>();

			Position endPosition = new Position(newEndX, newEndY);

			Position currentPosition = endPosition;

			//0 right
			//1 left
			//2 down
			//3 up
			List<Position> listOfDirections = new List<Position>
				{
					new Position(currentPosition.x + 1, currentPosition.y),
					new Position(currentPosition.x - 1, currentPosition.y),
					new Position(currentPosition.x , currentPosition.y+1),
					new Position(currentPosition.x , currentPosition.y-1)
				};

			//Drawing starting table connection
			foreach (var direction in listOfDirections)
			{

				if (matrix[direction.y, direction.x] != 1)
				{
					int z = 0;
					listOfPoint.Add(new Point(currentPosition.x, currentPosition.y));
					currentPosition = direction;
					int index = listOfDirections.IndexOf(direction);
					int m = NumberOfConnectionOnSide(endX, endY, endWidth, endHeight, index);
					while (z < 15)//+m*3)
					{
						
						matrix[currentPosition.y, currentPosition.x] = 2;
						
						if (index == 0)
						{
							currentPosition.x += 1;
							endTableDirection = "Right";
						}
						if (index == 1)
						{
							currentPosition.x -= 1;
							endTableDirection = "Left";
						}
						if (index == 2)
						{
							currentPosition.y += 1;
							endTableDirection = "Down";
						}
						if (index == 3)
						{
							currentPosition.y -= 1;
							endTableDirection = "Up";
						}
						listOfPoint.Add(new Point(currentPosition.x, currentPosition.y));
						z++;
					}
					this.dockingEndPositionX = currentPosition.x;
					this.dockingEndPositionY = currentPosition.y;
					break;
				}
			}

			Point[] points1 = listOfPoint.ToArray();


			return points1;
		}
		public Point [] Again()
		{
			Position startPosition = new Position(dockingStartPositionX, dockingStartPositionY);
			Position endPosition = new Position(dockingEndPositionX+1, dockingEndPositionY+1);

			List<Point> pointList = new List<Point>();
			Position currentPosition = startPosition;
			while (true)
			{
				if (currentPosition.x == endPosition.x && currentPosition.y == endPosition.y)
				{
					break;
				}
					

				List<Position> directions = new List<Position>
				{
						new Position(currentPosition.x +1,currentPosition.y),
						new Position(currentPosition.x -1,currentPosition.y),
						new Position(currentPosition.x ,currentPosition.y+1),
						new Position(currentPosition.x ,currentPosition.y-1)
				};

				double distance = Distance(currentPosition, endPosition);
				Position tempPosition = currentPosition;
				foreach (Position next in directions)
				{
					
					//if (!OccupiedByTable(next))
					//{
						double newDistance = Distance(next, endPosition);
						if (newDistance < distance)
							currentPosition = next;
		
					//}
				}
				//System.Console.WriteLine("X:" + currentPosition.x + "Y:" + currentPosition.y);
				pointList.Add(new Point(currentPosition.x, currentPosition.y));
				matrix[currentPosition.y, currentPosition.x] = 2;
			}
			Point[] points = pointList.ToArray();
			return points;
		}
		public Point [] AgainMyTry()
		{
			Position startPosition = new Position(dockingStartPositionX, dockingStartPositionY);
			Position endPosition = new Position(dockingEndPositionX, dockingEndPositionY);

			List<Point> pointList = new List<Point>();
			Position currentPosition = startPosition;
			while (true)
			{
				if (currentPosition.x == endPosition.x && currentPosition.y == endPosition.y) break;

				List<Position> directions = new List<Position>
				{
						new Position(currentPosition.x +1,currentPosition.y),
						new Position(currentPosition.x -1,currentPosition.y),
						new Position(currentPosition.x ,currentPosition.y+1),
						new Position(currentPosition.x ,currentPosition.y-1)
				};

				double distance = Distance(currentPosition, endPosition);
				foreach (Position next in directions)
				{
					double newDistance = Distance(next, endPosition);
				//	if (!OccupiedByTable(next))
					//{
						if (newDistance < distance)
							currentPosition = next;
				//	}

					if (OccupiedByLine(currentPosition))
					{
						List<Position> directions1 = new List<Position>
						{
								new Position(currentPosition.x +1,currentPosition.y),
								new Position(currentPosition.x -1,currentPosition.y),
								new Position(currentPosition.x ,currentPosition.y+1),
								new Position(currentPosition.x ,currentPosition.y-1)
						};
						foreach (var next1 in directions1)
						{
							if (!OccupiedByLine(next1) && !OccupiedByTable(next1))
								currentPosition = next1;
						}
					}
				}
				pointList.Add(new Point(currentPosition.x, currentPosition.y));
				matrix[currentPosition.y, currentPosition.x]=2;
				
			}
			Point[] points = pointList.ToArray();
			return points;
		}

		private double Distance(Position pos1, Position pos2)
		{
			return Math.Sqrt((pos1.x - pos2.x) * (pos1.x - pos2.x) + (pos1.y - pos2.y) * (pos1.y - pos2.y));
		}

		private bool OccupiedByLine(Position pos)
		{
			if (matrix[pos.y, pos.x] == 2)
				return true;
			return false;
		}

		private bool OccupiedByTable(Position pos)
		{
			if (matrix[pos.y, pos.x] == 4)
				return true;
			return false;
		}

		public void NewStartingCoordinates(int startX, int startY, int endX,int endY, int startWidth, int startHeight, int endWidth, int endHeight)
		{
			
			//Tablica se nalazi na mjestu zavrsne tablice(veza tablice sama sa sobom)
			if (startX == endX && startY == endY)
			{
				this.newEndX = startX+startWidth-1;
				this.newEndY = startY + startHeight-5;
				this.newStartX = startX+startWidth-1;
				this.newStartY = endY+5;
				matrix[newStartY, newStartX] = 2;
				matrix[newEndY, newEndX] = 2;
				
			}
			//Sve radi
			else
			{

				//Tablice su u istom redu pocetna tablica je s lijeve strane završne tablice- sve radi
				if (startY == endY && startX < endX)
				{
					//Zavrsna tablica je odmah desno do -radi
					if (startX + biggestWidth + tableSpace*2== endX)
					{
						
						this.newStartX = startX + startWidth-1;
						Random randomStart = new Random();
						this.newStartY = randomStart.Next(startY+5, startY + startHeight-10);
						//while (matrix[newStartY, newStartX + 1] == 2 || matrix[newStartY+5, newStartX + 1]==2 || matrix[newStartY - 5, newStartX + 1] == 2)
							while(OccupiedByNewStartingPoint(newStartX,newStartY))
							this.newStartY = randomStart.Next(startY+5, startY + startHeight-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndX = endX;
						Random randomEnd = new Random();
						this.newEndY = randomEnd.Next(endY+5, endY + endHeight-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndY = randomEnd.Next(endY+5, endY + endHeight-10);

						matrix[newEndY, newEndX] = 2;
					}
					//Zavrsna tablica nije desno do-radi
					else
					{
						Random startRandom = new Random();
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
						this.newStartY = startY;
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndY = endY;
						Random endRandom = new Random();
						this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);

						matrix[newEndY, newEndX] = 2;
					}
				}

				//Tablice su u istom redu pocetna tablica je desno od zavrsne-sve radi
				if (startY == endY && startX > endX)
				{
					//Završna tablica je odmah lijevo do-radi
					if (endX == startX - tableSpace * 2 - biggestWidth)
					{
						this.newStartX = startX;
						Random startRandom = new Random();
						this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndX = endX + endWidth-1;
						Random endRandom = new Random();
						this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);

						matrix[newEndY, newEndX] = 2;

					}
					//Završna tablica nije odmah lijevo do-radi
					else
					{
						this.newStartY = startY;
						Random startRandom = new Random();
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndY = endY;
						Random endRadnom = new Random();
						this.newEndX = endRadnom.Next(endX+5, endX + endWidth-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndX = endRadnom.Next(endX+5, endX + endWidth-10);

						matrix[newEndY, newEndX] = 2;

					}
				}

				//Tablice su u istom stupcu, pocetna tablica je iznad zavrsne tablice-sve radi
				if (startY < endY && startX == endX)
				{
					//Pocetna tablica je odmah iznad zavrsne-radi
					if (startY  + tableSpace + biggestHeight == endY)
					{
						System.Console.WriteLine("yo");
						this.newStartY = startY + startHeight-1;
						Random startRandom = new Random();
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndY = endY;
						Random endRandom = new Random();
						this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndX = endRandom.Next(endX+5, endX + endWidth+10);

						matrix[newEndY, newEndX] = 2;

					}
					//Pocetna tablica nije odmah iznad završne-radi
					else
					{
						this.newStartX = startX;
						Random startRandom = new Random();
						this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndX = endX;
						Random endRandom = new Random();
						this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);

						matrix[newEndY, newEndX]=2;
					}
				}

				//Tablice su u istom stupcu, pocetna tablica je ispod zavrsne tablice-sve radi
				if (startY > endY && startX == endX)
				{
					//Pocetna tablica je odmah ispod zavrsne-radi
					if (endY + biggestHeight + tableSpace == startY)
					{
						this.newStartY = startY;
						Random startRandom = new Random();
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
						//while (matrix[startY - 1, newStartX] == 2 || matrix[startY - 1, newStartX+5] == 2 || matrix[startY - 1, newStartX-5] == 2)
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndY = endY + endHeight-1;
						Random endRandom = new Random();
						this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);

						matrix[newEndY, newEndX] = 2;
					}
					//Pocetna tablica je ispod ali zavrsna nije odmah iznad-radi
					else
					{
						this.newStartX = startX;
						Random startRandom = new Random();
						this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);
						//while (matrix[newStartY, newStartX ] == 2 || matrix[newStartY+5, newStartX  ] == 2 || matrix[newStartY-5, newStartX] == 2)
						while (OccupiedByNewStartingPoint(newStartX, newStartY))
							this.newStartY = startRandom.Next(startY+5, startY + startHeight-10);

						matrix[newStartY, newStartX] = 2;

						this.newEndX = endX;
						Random endRandom = new Random();
						this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);
						//while (matrix[newEndY, endX ] == 2 || matrix[newEndY+5, endX-1] == 2 || matrix[newEndY-5, endX -1] == 2)
						while (OccupiedByNewStartingPoint(newEndX, newEndY))
							this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);

						matrix[newEndY, newEndX] = 2;
					}
				}

				//Zavrsna tablica je ispod desno-sve radi
				if (startY < endY && startX < endX)
				{
					this.newStartY = startY + startHeight-1;
					Random startRandom = new Random();
					this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
					while (OccupiedByNewStartingPoint(newStartX, newStartY))
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

					matrix[newStartY, newStartX] = 2;

					this.newEndX = endX;
					Random endRandom = new Random();
					this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);
					while (OccupiedByNewStartingPoint(newEndX, newEndY))
						this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);

					matrix[newEndY, newEndX] = 2;

				}

				//Zavrsna tablica je ispod lijevo-sve radi
				if (startY < endY && startX > endX)
				{
					this.newStartY = startY + startHeight-1;
					Random startRandom = new Random();
					this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
					while (OccupiedByNewStartingPoint(newStartX, newStartY))
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

					matrix[newStartY, newStartX] = 2;

					this.newEndX = endX + endWidth-1;
					Random endRandom = new Random();
					this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);
					while (OccupiedByNewStartingPoint(newEndX, newEndY))
						this.newEndY = endRandom.Next(endY+5, endY + endHeight-10);

					matrix[newEndY, newEndX] = 2;
				}

				//Zavrsna tablica je iznad desno-sve radi
				if (startY > endY && startX < endX)
				{
					this.newStartY = startY;
					Random startRandom = new Random();
					this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
					while (OccupiedByNewStartingPoint(newStartX, newStartY))
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

					matrix[newStartY, newStartX] = 2;

					this.newEndY = endY + endHeight-1;
					Random endRandom = new Random();
					this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);
					while (OccupiedByNewStartingPoint(newEndX, newEndY))
						this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);

					matrix[newEndY, newEndX] = 2;
				}

				//Zavrsna tablica je iznad lijevo-sve radi
				if (startY > endY && startX > endX)
				{
					this.newStartY = startY;
					Random startRandom = new Random();
					this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);
					while (OccupiedByNewStartingPoint(newStartX, newStartY))
						this.newStartX = startRandom.Next(startX+5, startX + startWidth-10);

					matrix[newStartY, newStartX] = 2;

					this.newEndY = endY + endHeight-1;
					Random endRandom = new Random();
					this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);
					while (OccupiedByNewStartingPoint(newEndX, newEndY))
						this.newEndX = endRandom.Next(endX+5, endX + endWidth-10);

					matrix[newEndY, newEndX] = 2;

				}
			}
		}

		private bool OccupiedByNewStartingPoint(int startX, int startY)
		{
			for(int k = startY-8; k < startY + 16; k++)
			{
				for(int l = startX-8; l < startX+16; l++)
				{
					if (matrix[k, l] == 2)
						return true;
				}
			}
			return false;
		}

		public Point [] TableConnectionStartTable(string parentTableType)
		{
			List<Point> listOfPoints = new List<Point>();

				if (startTableDirection == "Left")
				{
					listOfPoints.Add(new Point(newStartX-8, newStartY-5));
					listOfPoints.Add(new Point(newStartX-8, newStartY+5 ));
				}
				if (startTableDirection == "Right")
				{
					listOfPoints.Add(new Point(newStartX +8, newStartY + 5));
					listOfPoints.Add(new Point(newStartX +8, newStartY-5));
				}
				if (startTableDirection == "Up")
				{
					listOfPoints.Add(new Point(newStartX + 5, newStartY - 7));
					listOfPoints.Add(new Point(newStartX - 5 , newStartY- 7));
				}
				if (startTableDirection == "Down")
				{
					listOfPoints.Add(new Point(newStartX + 5, newStartY + 7));
					listOfPoints.Add(new Point(newStartX - 5, newStartY + 7));
				}

			Point[] arrayPoints = listOfPoints.ToArray();
			return arrayPoints;

		}

		public Point [] TableConnectionsEndTable(string endTableType, string parentTableType)
		{
			List<Point> listOfPoints = new List<Point>();

			if (endTableType == "1" && parentTableType=="1")
			{

				if (startTableDirection == "Left")
				{
					listOfPoints.Add(new Point(newEndX - 8, newEndY - 5));
					listOfPoints.Add(new Point(newEndX - 8, newEndY + 5));
				}
				if (startTableDirection == "Right")
				{
					listOfPoints.Add(new Point(newEndX + 8, newEndY + 5));
					listOfPoints.Add(new Point(newEndX + 8, newEndY - 5));
				}
				if (startTableDirection == "Up")
				{
					listOfPoints.Add(new Point(newEndX + 5, newEndY - 7));
					listOfPoints.Add(new Point(newEndX - 5, newEndY - 7));
				}
				if (startTableDirection == "Down")
				{
					listOfPoints.Add(new Point(newEndX + 5, newEndY + 7));
					listOfPoints.Add(new Point(newEndX - 5, newEndY + 7));
				}
			}
			else
			{
				if (endTableDirection == "Left")
				{
					listOfPoints.Add(new Point(newEndX , newEndY + 5));
					listOfPoints.Add(new Point(newEndX - 15 , newEndY));
					listOfPoints.Add(new Point(newEndX, newEndY - 5));
				}
				if (endTableDirection == "Right")
				{
					listOfPoints.Add(new Point(newEndX, newEndY + 5));
					listOfPoints.Add(new Point(newEndX + 15, newEndY));
					listOfPoints.Add(new Point(newEndX, newEndY - 5));
				}
				if (endTableDirection == "Up")
				{
					listOfPoints.Add(new Point(newEndX - 5, newEndY));
					listOfPoints.Add(new Point(newEndX, newEndY - 15));
					listOfPoints.Add(new Point(newEndX + 5 , newEndY));
				}
				if (endTableDirection == "Down")
				{
					listOfPoints.Add(new Point(newEndX - 5, newEndY));
					listOfPoints.Add(new Point(newEndX, newEndY + 15));
					listOfPoints.Add(new Point(newEndX + 5, newEndY));
				}
			}
			Point[] points = listOfPoints.ToArray();
			return points;
		}

		private int NumberOfConnectionOnSide( int startX, int startY, int startWidth, int startHeight, int index)
		{
			int number = 0;

			if (index == 0)
			{
				for( int k = startY; k < startY + startHeight;k++)
				{
					if (matrix[k, startX + startWidth-1] == 2)
						number++;
				}
			}
			if(index== 1)
			{
				for (int k = startY; k < startY + startHeight; k++)
				{
					if (matrix[k, startX] == 2)
						number++;
				}
			}

			if (index == 2)
			{
				for(int k = startX; k < startX + startWidth; k++)
				{
					if (matrix[startY+startHeight-1, k] == 2)
					{
						number++;
					}
				}
			}
			if (index == 3)
			{
				for (int k = startX; k < startX + startWidth; k++)
				{
					if (matrix[startY, k] == 2)
					{
						number++;
					}
				}
			}
			return number;
		}
		
	}
}
