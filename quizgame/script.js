const quizData = [
    {
        question: "What is the capital of Australia?",
        answers: ["Sydney", "Melbourne", "Canberra", "Brisbane"],
        correctAnswer: "Canberra"
    },
    {
        question: "Who painted the Mona Lisa?",
        answers: ["Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Michelangelo"],
        correctAnswer: "Leonardo da Vinci"
    },
    {
        question: "What is the largest ocean in the world?",
        answers: ["Atlantic Ocean", "Arctic Ocean", "Indian Ocean", "Pacific Ocean"],
        correctAnswer: "Pacific Ocean"
    }
];

const quizContainer = document.getElementById("quiz");
const resultsContainer = document.getElementById("results");

function buildQuiz() {
    const output = [];

    quizData.forEach((questionData, index) => {
        const answers = [];

        for (let i = 0; i < questionData.answers.length; i++) {
            answers.push(
                `<label>
                    <input type="radio" name="question${index}" value="${questionData.answers[i]}">
                    ${questionData.answers[i]}
                </label>`
            );
        }

        output.push(
            `<div class="question">${index + 1}. ${questionData.question}</div>
            <div class="answers">${answers.join("")}</div>`
        );
    });

    quizContainer.innerHTML = output.join("");
}

function showResults() {
    const answerContainers = quizContainer.querySelectorAll(".answers");
    let numCorrect = 0;

    quizData.forEach((questionData, index) => {
        const answerContainer = answerContainers[index];
        const selector = `input[name=question${index}]:checked`;
        const userAnswer = (answerContainer.querySelector(selector) || {}).value;

        if (userAnswer === questionData.correctAnswer) {
            numCorrect++;
        }
    });

    resultsContainer.innerHTML = `${numCorrect} out of ${quizData.length} correct`;
}

buildQuiz();
