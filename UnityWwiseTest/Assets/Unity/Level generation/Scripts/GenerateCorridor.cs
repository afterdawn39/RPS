using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction {North, East, South, West};

public class GenerateCorridor
{
    public int startXPos;         // The x coordinate for the start of the corridor.
    public int startYPos;         // The y coordinate for the start of the corridor.
    public int corridorLength;    // How many units long the corridor is.
    public Direction direction;   // Which direction the corridor is heading from it's room.
    
    public int EndPositionX
    {
        get
        {
            if (direction == Direction.North || direction == Direction.South)
                return startXPos;
            if (direction == Direction.East)
                return startXPos + corridorLength - 1;
            return startXPos - corridorLength + 1;
        }
    }

    public int EndPositionY
    {
        get
        {
            if (direction == Direction.East || direction == Direction.West)
                return startYPos;
            if (direction == Direction.North)
                return startYPos + corridorLength - 1;
            return startYPos - corridorLength + 1;
        }
    }

    public void CorridorGen(GenerateRoom room, IntRange length, IntRange roomWidth, IntRange roomHeight, int columns, int rows, bool firstCorridor)
    {
        direction = (Direction)Random.Range(0,4);

        Direction oppositeDirection = (Direction)(((int)room.enteringCorridor + 2) % 4);

        if (!firstCorridor && direction == oppositeDirection)
        {
            // Rotate the direction 90 degrees clockwise (North becomes East, East becomes South, etc).
            // This is a more broken down version of the opposite direction operation above but instead of adding 2 we're adding 1.
            // This means instead of rotating 180 (the opposite direction) we're rotating 90.
            int directionInt = (int)direction;
            directionInt++;
            directionInt = directionInt % 4;
            direction = (Direction)directionInt;

        }

        // Set a random length.
        corridorLength = length.Random;

        // Create a cap for how long the length can be (this will be changed based on the direction and position).
        int maxLength = length.m_Max;

        switch (direction)
        {
            // If the choosen direction is North (up)...
            case Direction.North:
                // ... the starting position in the x axis can be random but within the width of the room.
                startXPos = Random.Range(room.xPos, room.xPos + room.roomWidth - 1);

                // The starting position in the y axis must be the top of the room.
                startYPos = room.yPos + room.roomHeight;

                // The maximum length the corridor can be is the height of the board (yWorld) but from the top of the room (y pos + height).
                maxLength = rows - startYPos - roomHeight.m_Min;
                break;
            case Direction.East:
                startXPos = room.xPos + room.roomWidth;
                startYPos = Random.Range(room.yPos, room.yPos + room.roomHeight - 1);
                maxLength = columns - startXPos - roomWidth.m_Min;
                break;
            case Direction.South:
                startXPos = Random.Range(room.xPos, room.xPos + room.roomWidth);
                startYPos = room.yPos;
                maxLength = startYPos - roomHeight.m_Min;
                break;
            case Direction.West:
                startXPos = room.xPos;
                startYPos = Random.Range(room.yPos, room.yPos + room.roomHeight);
                maxLength = startXPos - roomWidth.m_Min;
                break;
        }

        corridorLength = Mathf.Clamp(corridorLength, 1, maxLength);


    }

    
}


    
