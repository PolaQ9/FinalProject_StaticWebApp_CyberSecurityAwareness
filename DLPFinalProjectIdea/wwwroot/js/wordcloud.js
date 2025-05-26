window.renderWordCloud = function (data) {
    if (!Array.isArray(data)) {         // Ensuring input is an array
        console.error("renderWordCloud: Expected array but got", data);
        return;
    }

    const formatted = data      // Format the data into [word, count] pairs
        .map(item => {
            if (!Array.isArray(item) || item.length < 2) return null;
            const word = item[0]?.trim();
            const count = parseInt(item[1]);
            return word ? [word, count] : null;     // returning the formatted pair
        })
        .filter(item => item !== null);     // Remove any null entries

    console.log("Formatted word list:", formatted);     // For testing, showing what is being sent

    if (formatted.length === 0) {       
        console.warn("No valid keywords to render.");       // exiting if no keyword to render
        return;
    }

    const canvas = document.getElementById('wordCloudCanvas');
    const ctx = canvas.getContext('2d');
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    WordCloud(canvas, {
        list: formatted,
        gridSize: 10,
        weightFactor: 10,
        fontFamily: 'Impact',
        color: 'random-dark',
        rotateRatio: 0.5
    });
};
