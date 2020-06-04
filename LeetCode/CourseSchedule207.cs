using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace LeetCode
{
    public class CourseSchedule207
    {
        /*
         * Problem : https://leetcode.com/problems/course-schedule/
         * There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.

            Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
            
            Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
            
             
            Example 1:
            
            Input: numCourses = 2, prerequisites = [[1,0]]
            Output: true
            Explanation: There are a total of 2 courses to take. 
                         To take course 1 you should have finished course 0. So it is possible.
            
            Example 2:
            
            Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
            Output: false
            Explanation: There are a total of 2 courses to take. 
                         To take course 1 you should have finished course 0, and to take course 0 you should
                         also have finished course 1. So it is impossible.
            
            Constraints:
            
                The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
                You may assume that there are no duplicate edges in the input prerequisites.
                1 <= numCourses <= 10^5
            
                
         */
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            bool canFinish = false;

            // Build Graph from the list of edges
            List<List<int>> graphUsingAdjacencyList = BuildGraph(numCourses, prerequisites);

            var visitedTracker = new bool[graphUsingAdjacencyList.Count];
            var vertexToStartSearch = 0;
            // Traverse the Graph in the Depth First Search. If visited any node again then a cycle exists. 
            DepthFirstSearch(graphUsingAdjacencyList, visitedTracker, vertexToStartSearch);

            return canFinish;

        }

        private void DepthFirstSearch(List<List<int>> graphUsingAdjacencyList, bool[] visitedTracker, int vertex)
        {

            var isCycle = false;

            // Traverse each Node/Vertex

            if (visitedTracker[vertex])
            {
                return;
            }

            visitedTracker[vertex] = true;

            List<int> neighbors = graphUsingAdjacencyList[vertex];
            foreach (var neighbor in neighbors)
            {
                if (visitedTracker[neighbor])
                {
                    return;
                }

                DepthFirstSearch(graphUsingAdjacencyList, visitedTracker, neighbor);
            }
        }

        private List<List<int>> BuildGraph(int numCourses, int[][] prerequisites)
        {
            List<List<int>> adjacencyList = new List<List<int>>(numCourses);

            // Initialization of the internal List
            for (int courseIndex = 0; courseIndex < numCourses; courseIndex++)
            {
                adjacencyList.Add(new List<int>());
            }

            // We have jagged array, and the internal array would always contains at max 2 elements which is representation of an edge.
            for (int index = 0; index < prerequisites.Length; index++)
            {
                var edge = prerequisites[index];
                var from = edge[0];
                var to = edge[1];
                adjacencyList[from].Add(to);
            }
            return adjacencyList;
        }
    }
}
