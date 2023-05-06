const questions = [
  {
    question: "Who is the developer of this app?",
    answers: [
      { text: "Alahira Jeffrey", correct: true },
      { text: "Alahira Daniel", correct: false },
      { text: "Alahira Deborah", correct: false },
      { text: "Alahira Esther", correct: false },
    ],
  },
  {
    question: "What is the largest animal in the world?",
    answers: [
      { text: "Dog", correct: false },
      { text: "Elephant", correct: false },
      { text: "Blue Whale", correct: true },
      { text: "Girrafe", correct: false },
    ],
  },
  {
    question: "What is the smallest animal here?",
    answers: [
      { text: "Dog", correct: false },
      { text: "House Rat", correct: true },
      { text: "Shark", correct: false },
      { text: "Cat", correct: false },
    ],
  },
  {
    question: "What is the smallest country in the world?",
    answers: [
      { text: "Vatican City", correct: true },
      { text: "Nigeria", correct: false },
      { text: "Cameroun", correct: false },
      { text: "Italy", correct: false },
    ],
  },
  {
    question: "What is the most populous black country in the world?",
    answers: [
      { text: "South Africa", correct: false },
      { text: "Nigeria", correct: true },
      { text: "Ghana", correct: false },
      { text: "Botswana", correct: false },
    ],
  },
];

const questionElement = document.getElementById("question");
const answerButton = document.getElementById("answer-buttons");
const nextButton = document.getElementById("next-btn");

let currentQuestionIndex = 0;
let score = 0;

function startQuiz() {
  currentQuestionIndex = 0;
  score = 0;
  nextButton.innerHTML = "Next Question";
  showQuestion();
}

function showQuestion() {
  resetState();
  let currentQuestion = questions[currentQuestionIndex];
  let questionNumber = currentQuestionIndex + 1;
  questionElement.innerHTML = questionNumber + ". " + currentQuestion.question;

  currentQuestion.answers.forEach((answer) => {
    const button = document.createElement("button");
    button.innerHTML = answer.text;
    button.classList.add("btn");
    answerButton.appendChild(button);
    if (answer.correct) {
      button.dataset.correct = answer.correct;
    }
    button.addEventListener("click", selectAnswer);
  });
}

function resetState() {
  nextButton.style.display = "none";
  while (answerButton.firstChild) {
    answerButton.removeChild(answerButton.firstChild);
  }
}

function selectAnswer(e) {
  const selectedBtn = e.target;
  const isCorrect = selectedBtn.dataset.correct === "true";
  if (isCorrect) {
    selectedBtn.classList.add("correct");
    score++;
  } else {
    selectedBtn.classList.add("incorrect");
  }
  Array.from(answerButton.children).forEach((button) => {
    if (button.dataset.correct === "true") {
      button.classList.add("correct");
    }
    button.disabled = true;
  });
  nextButton.style.display = "block";
}

function showScore() {
  resetState();
  questionElement.innerHTML = `You scored ${score} out of ${questions.length}`;

  nextButton.innerHTML = "Play Again";
  nextButton.style.display = "block";
}

function handleNextButton() {
  currentQuestionIndex++;
  if (currentQuestionIndex < questions.length) {
    showQuestion();
  } else {
    showScore();
  }
}

nextButton.addEventListener("click", () => {
  if (currentQuestionIndex < questions.length) {
    handleNextButton();
  } else {
    startQuiz();
  }
});

startQuiz();
