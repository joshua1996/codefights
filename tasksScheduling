int tasksScheduling(int workingHours, int[] tasks) {
  int answer = 0;

            int dayHourWork = 0;
            List<int> defaultCont = new List<int>();
            List<int> kick = new List<int>();
            int remaining = 0;
            int left = 0;
            int right = 0;

            Array.Sort(tasks);
            Array.Reverse(tasks);
            foreach (var item in tasks)
            {
                defaultCont.Add(item);
                Console.Write(item + ", ");
            }
            Console.WriteLine("");

            again: for (int i = 0; i < defaultCont.Count; i++)
            {
                if (tasks[i] > workingHours)
                {
                    answer = -1;
                    break;
                }
                else
                {
                    dayHourWork += defaultCont[i];
                    remaining = workingHours - dayHourWork;
                    if (remaining % 2 == 0)
                    {
                        int duplicateTimes = 0;
                        left = remaining / 2;
                        for (int j = i + 1; j < defaultCont.Count; j++)
                        {
                            if (defaultCont[j] == left)
                            {
                                duplicateTimes += 1;
                                defaultCont.RemoveAt(j);
                                j -= 1;
                            }
                            if (duplicateTimes == 2)
                            {
                                defaultCont.RemoveAt(0);
                                dayHourWork += (left * 2);
                                answer += 1;
                                dayHourWork = 0;
                                defaultCont.Sort();
                                defaultCont.Reverse();
                                Console.WriteLine(defaultCont.Count());
                                goto again;
                            }
                        }
                    }
                    //  left = remaining - (remaining - 1);
                    //  right = remaining - left;

                    if (dayHourWork == workingHours)
                    {
                        answer += 1;
                        dayHourWork = 0;
                    }
                    else if (dayHourWork > workingHours)
                    {
                        dayHourWork -= defaultCont[i];
                        kick.Add(defaultCont[i]);
                        defaultCont.RemoveAt(i);
                        i -= 1;
                    }
                    else if (i == defaultCont.Count - 1)
                    {
                        answer += 1;
                        defaultCont.Clear();
                        defaultCont = kick.ToList();
                        kick.Clear();
                        i = 0;
                        dayHourWork = 0;
                    }
                }
            }
            if (kick.Count > 0)
            {

                defaultCont.Clear();
                defaultCont = kick.ToList();
                kick.Clear();
                answer += 1;
                dayHourWork = 0;
                goto again;
            }

            Console.WriteLine(answer);

    return answer;
}
